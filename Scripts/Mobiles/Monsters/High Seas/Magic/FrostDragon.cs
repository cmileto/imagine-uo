using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a frost dragon corpse" )]
	public class FrostDragon : BaseCreature
	{
		[Constructable]
		public FrostDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a frost dragon";
			Body = Utility.RandomList( 12, 59 );
			BaseSoundID = 951;

			SetStr( 1328, 1340 );
			SetDex( 110, 112 );
			SetInt( 617, 680 );

			SetHits( 478, 495 );
			SetMana( 617, 680 );

			SetDamage( 26, 35 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 89, 91 );
			SetResistance( ResistanceType.Fire, 59, 68 );
			SetResistance( ResistanceType.Cold, 85, 90 );
			SetResistance( ResistanceType.Poison, 66 );
			SetResistance( ResistanceType.Energy, 66, 74 );

			SetSkill( SkillName.EvalInt, 30.1, 40.0 );
			SetSkill( SkillName.Magery, 30.1, 40.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 92.5 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 60;

			Tamable = false;
		}

		//TODO: Area Cold Attack

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}

		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 33; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }

		public FrostDragon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}