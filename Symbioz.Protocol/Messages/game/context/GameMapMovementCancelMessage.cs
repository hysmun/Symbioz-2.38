


















using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Protocol.Types;
using SSync.IO;
using SSync.Messages;

namespace Symbioz.Protocol.Messages
{

public class GameMapMovementCancelMessage : Message
{

public const ushort Id = 953;
public override ushort MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public GameMapMovementCancelMessage()
{
}

public GameMapMovementCancelMessage(ushort cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(cellId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}