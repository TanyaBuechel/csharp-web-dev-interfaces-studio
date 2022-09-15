using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
       
        public bool IsAudio { get; set; }
        public CD(string name, int storageCapacity, string content, string discType, bool isAudio) : base(name, storageCapacity, content, discType)
        {
            IsAudio = true;
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }


        // TODO: Implement your custom interface.
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
