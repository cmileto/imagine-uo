using System;
using Server;

namespace Server.Items
{
	public class AcidProofRope : Item
	{	
		public override int LabelNumber{ get{ return 1074886; } } // Acid Proof Rope
		
		[Constructable]
		public AcidProofRope() : base( 0x20D )
		{
			Weight = 1.0;
			Hue = 0x3D1; // TODO check
			ItemValue = ItemValue.Common;
		}

		public AcidProofRope( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}

