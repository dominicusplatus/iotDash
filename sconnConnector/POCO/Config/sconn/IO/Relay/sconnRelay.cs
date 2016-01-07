﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using sconnConnector.POCO.Config.sconn;

namespace sconnConnector.POCO.Config
{



    public class sconnRelay : IAlarmSystemConfigurationEntity, ISerializableConfiguration, IFakeAbleConfiguration
    {
        public int Id { get; set; }

        public sconnOutputType Type { get; set; }

        public int Value { get; set; }

        public int NameId { get; set; }

        public bool Enabled { get; set; }

        public string Name { get; set; }

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public sconnRelay()
        {
            Name = "Relay";
        }

        public sconnRelay(byte[] rawCfg) : this()
        {
                this.Deserialize(rawCfg);
        }

        public byte[] Serialize()
        {
            try
            {
                byte[] buffer = new byte[ipcDefines.RelayMemSize];
                buffer[ipcDefines.mAdrRelayType] = (byte)Type;
                buffer[ipcDefines.mAdrRelayEnabled] = (byte)(Enabled ? 1 : 0);
                buffer[ipcDefines.mAdrRelayVal] = (byte)Value;
                buffer[ipcDefines.mAdrRelayNameAddr] = (byte)NameId;
                return buffer;
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
                return null;
            }

        }

        public void Deserialize(byte[] buffer)
        {
            try
            {
                Type = (sconnOutputType)buffer[ipcDefines.mAdrRelayType];
                Value = buffer[ipcDefines.mAdrRelayVal];
                NameId = buffer[ipcDefines.mAdrRelayNameAddr];
                Enabled = buffer[ipcDefines.mAdrRelayEnabled] > 0 ? true : false;
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
            }

        }

        public void Fake()
        {
            try
            {
                this.Id = 0;
                this.Enabled = true;
                this.Name = Guid.NewGuid().ToString();
                this.NameId = 0;
                this.Type = sconnOutputType.AlarmNormallyActive;
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
            }

        }
    }


}
