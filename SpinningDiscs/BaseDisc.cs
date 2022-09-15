using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        
        public string Content { get; set; }
        public string DiscType { get; set; }
        public BaseDisc (string name, int storageCapacity, string content, string discType)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Content = content;
            DiscType = discType;
        }
    }
}
