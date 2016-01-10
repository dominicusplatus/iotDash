﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Runtime.Serialization;
 

namespace iotDbConnector.DAL
{
    [DataContract(IsReference = true)]
    public class Device
    {
        private int _Id;


        [DataMember]
        [Required]
        [Key]
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public void Load(Device dev)
        {
            this.Actions = dev.Actions;
            this.Credentials = dev.Credentials;
            this.DeviceLocation = dev.DeviceLocation;
            this.DeviceMaps = dev.DeviceMaps;
            this.DeviceName = dev.DeviceName;
            this.EndpInfo = dev.EndpInfo;
            this.Properties = dev.Properties;
            this.Site = dev.Site;
            this.Type = dev.Type;

        }

        [DataMember]
        [Required]
        public string DeviceName { get; set; }

        [DataMember]
        [Required]
        public virtual EndpointInfo EndpInfo { get; set; }

        [DataMember]
        public virtual DeviceCredentials Credentials { get; set; }

        [DataMember]
        public virtual List<DeviceAction> Actions { get; set; }

        [DataMember]
        public virtual List<DeviceProperty> Properties { get; set; }

        [DataMember]
        [Required]
        public virtual Location DeviceLocation { get; set; }

        [DataMember]
        [Required]
        public virtual DeviceType Type { get; set; }

        [DataMember]
        [Required]
        public virtual Site Site { get; set; }

        [DataMember]
        public bool IsVirtual { get; set; }

        [DataMember]
        public virtual List<MapDefinition> DeviceMaps { get; set; }

        public Device()
        {
            Actions = new List<DeviceAction>();
            Properties = new List<DeviceProperty>();
        }

       


    }
}