using Terraria.ModLoader; //Most of this code is from pastebin and tutorials, Plz no copyright flags or anything that will get me banned from the mod browser.

namespace lightsword
{
	class lightsword : Mod
	{
		public lightsword()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
