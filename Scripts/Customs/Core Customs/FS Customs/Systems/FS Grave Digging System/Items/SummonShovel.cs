using System;
using Server;
using Server.Engines.Harvest;

namespace Server.Items
{
	public class SummonShovel : BaseHarvestTool
	{
		public override HarvestSystem HarvestSystem{ get{ return Mining.System; } }

		[Constructable]
		public SummonShovel() : this( Utility.RandomList( 5 ) )
		{
		}

		[Constructable]
		public SummonShovel( int uses ) : base( uses, 0xF39 )
		{
			Weight = 5.0;
			Hue = 1461;
			Name = "shovel of summoning";

			ItemValue = ItemValue.Legendary;
		}

		public SummonShovel( Serial serial ) : base( serial )
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