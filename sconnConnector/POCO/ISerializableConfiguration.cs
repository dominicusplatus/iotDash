﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconnConnector.POCO
{
    public interface ISerializableConfiguration
    {
        byte[] Serialize();
        void Deserialize(byte[] buffer);
    }
}
