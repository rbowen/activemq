//
// Marshalling code for Open Wire Format for MessageDispatch
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;

using OpenWire.Core;

namespace OpenWire.Core.Commands
{
    public class MessageDispatch : BaseCommand
    {
    			public const byte ID_MessageDispatch = 21;
    			
        ConsumerId consumerId;
        ActiveMQDestination destination;
        Message message;
        int redeliveryCounter;



        // TODO generate Equals method
        // TODO generate GetHashCode method
        // TODO generate ToString method


        public override byte GetCommandType() {
            return ID_MessageDispatch;
        }


        // Properties

        public ConsumerId ConsumerId
        {
            get { return consumerId; }
            set { this.consumerId = value; }            
        }

        public ActiveMQDestination Destination
        {
            get { return destination; }
            set { this.destination = value; }            
        }

        public Message Message
        {
            get { return message; }
            set { this.message = value; }            
        }

        public int RedeliveryCounter
        {
            get { return redeliveryCounter; }
            set { this.redeliveryCounter = value; }            
        }

    }
}
