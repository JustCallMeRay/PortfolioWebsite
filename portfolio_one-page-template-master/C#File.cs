using system;

namespace MyNameSpace
{
	public static class NpcUtils
	{
		// enum CharTab0: byte	// Enum or Array? 
		// {
		// 	// 0 A 1 B 2 C ...etc... 25 ab 26ac ...etc... 
		// 	A = 0; 
		// }

		// enum CharTab1 : byte
		// {

		// }
		
		// enum CharTab2 : byte
		// {

		// }

		// enum CharTab3 : byte
		// {

		// }

		string[] CharTab0 = 	//async load 
		{ /* lookup from disk*/ 	}

		[Flags]
		enum traits : byte
		{
			None = 0; //I think this is going to ruin it.
			isMale = 1;
			likesMen = 2;
			age1 = 4;
			age2 = 8; 
			alli1 = 16;
			alli2 = 32;
			alli3 = 64; 
			x = 124;

			//I may have to do this outside the enum :(
			isOld = age1 & age2;
			isChild = !age1 & !age2; //does not work in this situation? ~ instead? 
			isTeen = age1 & !age2;
			isMiddAge = !age1 & age2;
			
			isGood = !alli2 & !(alli1 & alli3);
			isNeutralAcross = alli2 & !(alli1 & !alli3);
			isEvil = alli1 & (alli2 ^ alli3);  
			isLawful = !alli3 & !(alli1 & !alli2);
			isNeutralDown = alli3 & !(alli1 & alli2);
			isChaotic = alli1 & !(alli2 ^ alli3);

		}

		public static string IntToName(int aInt)
		{
			byte[] CharArr = BitConverter.GetBytes(aInt);
			
			return (CharTab0[CharArr[0]] + CharTab1[CharArr[1]] + CharTab2[CharArr[2]] + CharTab3[CharArr[3]]);
		}

		public static NPCDataVerbose interperateNPCData(NPCData Data)
		{
			traits T = (traits) Data.NpcTraits;
			NPCDataVerbose ret = new(); // NPCDataVerbose;
			ret.NpcName = IntToName(Data.NpcName);
			ret.isMale = T.HasFlag(traits.isMale);
			ret.likesMen
			ret.likesGirls
			ret.isTeen
			ret.isOld
			 
		}

	}
		
	struct NPCData
	{
		int NpcName; 
		byte NpcTraits;
	}

	struct NPCDataVerbose
	{
		string NpcName;
		bool isMale;
		bool likesMen;
		bool likesGirls;
		bool isTeen;
		bool isOld;
		int Allignment;
		
		//bool choice1;
	}

}
