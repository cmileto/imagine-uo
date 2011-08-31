using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
    //Based Off War Hammer
	[FlipableAttribute( 0x48C0, 0x481 )]
	public class GargishWarHammer : BaseBashing
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.WhirlwindAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.CrushingBlow; } }

		public override int AosStrengthReq{ get{ return 95; } }
		public override int AosMinDamage{ get{ return 17; } }
		public override int AosMaxDamage{ get{ return 18; } }
		public override int AosSpeed{ get{ return 28; } }
		public override float MlSpeed{ get{ return 3.75f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 8; } }
		public override int OldMaxDamage{ get{ return 36; } }
		public override int OldSpeed{ get{ return 31; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 110; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Bash2H; } }

        public override bool CanBeWornByGargoyles { get { return true; } }

		[Constructable]
        public GargishWarHammer() : base(0x48C0)
		{
			Weight = 10.0;
			Layer = Layer.TwoHanded;
		}

		public GargishWarHammer( Serial serial ) : base( serial )
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