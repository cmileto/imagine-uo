using System;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class Runescriber : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		[Constructable]
		public Runescriber() : base( "the runescriber" )
		{
			SetSkill( SkillName.Imbuing, 75.0, 98.0 );
			SetSkill( SkillName.Inscribe, 36.0, 68.0 );
			SetSkill( SkillName.ArmsLore, 36.0, 68.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBRunescriber() );
		}

		public Runescriber( Serial serial ) : base( serial )
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