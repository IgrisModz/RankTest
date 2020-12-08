namespace RankTest.Core
{
    public class Class
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public WeaponIndex PrimaryWeapon { get; set; }

        public Proficiencies PrimaryWeaponProficiency { get; set; }

        public Attachments PrimaryWeaponAttachment1 { get; set; }

        public Attachments PrimaryWeaponAttachment2 { get; set; }

        public Reticle PrimaryWeaponReticle { get; set; }

        public Camos PrimaryWeaponCamo { get; set; }

        public WeaponIndex SecondaryWeapon { get; set; }

        public Proficiencies SecondaryWeaponProficiency { get; set; }

        public Attachments SecondaryWeaponAttachment1 { get; set; }

        public Attachments SecondaryWeaponAttachment2 { get; set; }

        public Reticle SecondaryWeaponReticle { get; set; }

        public Camos SecondaryWeaponCamo { get; set; }

        public Lethal Lethal { get; set; }

        public Tactical Tactical { get; set; }

        public Perks1 Perk1 { get; set; }

        public Perks2 Perk2 { get; set; }

        public Perks3 Perk3 { get; set; }

        public StrikePackage StrikePackage { get; set; }

        public Assault Assault1 { get; set; }

        public Assault Assault2 { get; set; }

        public Assault Assault3 { get; set; }

        public Support Support1 { get; set; }

        public Support Support2 { get; set; }

        public Support Support3 { get; set; }

        public Specialist Specialist1 { get; set; }

        public Specialist Specialist2 { get; set; }

        public Specialist Specialist3 { get; set; }

        public Deathstreaks Deathstreak { get; set; }

        public bool Godmode { get; set; }
    }
}
