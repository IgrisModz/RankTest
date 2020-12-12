using IgrisLib;
using System;

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

        public PS3API PS3 { get; }

        public FunctionsExtension Extension { get; }

        public Class(PS3API ps3, FunctionsExtension extension)
        {
            PS3 = ps3;
            Extension = extension;
        }

        public T GetEnumSelection<T>(byte value)
        {
            return (T)Enum.Parse(typeof(T), value.ToString());
        }

        private T GetClassInfo<T>(Addresses.Classes offset, uint index)
        {
            return GetEnumSelection<T>(Extension.ReadByte((uint)offset + (index * (uint)Addresses.Classes.ClassInterval)));

        }

        private string GetClassName(uint index)
        {
            return Extension.ReadString((uint)Addresses.Classes.ClassName1 + (index * (uint)Addresses.Classes.ClassInterval));
        }

        public Class Get()
        {
            return new Class(PS3, Extension)
            {
                Name = GetClassName(Id),
                PrimaryWeapon = GetClassInfo<WeaponIndex>(Addresses.Classes.PrimaryWeapon, Id),
                PrimaryWeaponProficiency = GetClassInfo<Proficiencies>(Addresses.Classes.PrimaryWeaponProficiency, Id),
                PrimaryWeaponAttachment1 = GetClassInfo<Attachments>(Addresses.Classes.PrimaryWeaponAttachment1, Id),
                PrimaryWeaponAttachment2 = GetClassInfo<Attachments>(Addresses.Classes.PrimaryWeaponAttachment2, Id),
                PrimaryWeaponReticle = GetClassInfo<Reticle>(Addresses.Classes.PrimaryWeaponReticle, Id),
                PrimaryWeaponCamo = GetClassInfo<Camos>(Addresses.Classes.PrimaryWeaponCamo, Id),
                SecondaryWeapon = GetClassInfo<WeaponIndex>(Addresses.Classes.SecondaryWeapon, Id),
                SecondaryWeaponProficiency = GetClassInfo<Proficiencies>(Addresses.Classes.SecondaryWeaponProficiency, Id),
                SecondaryWeaponAttachment1 = GetClassInfo<Attachments>(Addresses.Classes.SecondaryWeaponAttachment1, Id),
                SecondaryWeaponAttachment2 = GetClassInfo<Attachments>(Addresses.Classes.SecondaryWeaponAttachment2, Id),
                SecondaryWeaponReticle = GetClassInfo<Reticle>(Addresses.Classes.SecondaryWeaponReticle, Id),
                SecondaryWeaponCamo = GetClassInfo<Camos>(Addresses.Classes.SecondaryWeapon, Id),
                Lethal = GetClassInfo<Lethal>(Addresses.Classes.Lethal, Id),
                Tactical = GetClassInfo<Tactical>(Addresses.Classes.Tactical, Id),
                Perk1 = GetClassInfo<Perks1>(Addresses.Classes.Perk1, Id),
                Perk2 = GetClassInfo<Perks2>(Addresses.Classes.Perk2, Id),
                Perk3 = GetClassInfo<Perks3>(Addresses.Classes.Perk3, Id),
                StrikePackage = GetClassInfo<StrikePackage>(Addresses.Classes.StrikePackage, Id),
                Assault1 = GetClassInfo<Assault>(Addresses.Classes.Assault1, Id),
                Assault2 = GetClassInfo<Assault>(Addresses.Classes.Assault2, Id),
                Assault3 = GetClassInfo<Assault>(Addresses.Classes.Assault3, Id),
                Support1 = GetClassInfo<Support>(Addresses.Classes.Support1, Id),
                Support2 = GetClassInfo<Support>(Addresses.Classes.Support2, Id),
                Support3 = GetClassInfo<Support>(Addresses.Classes.Support3, Id),
                Specialist1 = GetClassInfo<Specialist>(Addresses.Classes.Specialist1, Id),
                Specialist2 = GetClassInfo<Specialist>(Addresses.Classes.Specialist2, Id),
                Specialist3 = GetClassInfo<Specialist>(Addresses.Classes.Specialist3, Id),
                Deathstreak = GetClassInfo<Deathstreaks>(Addresses.Classes.Deathstreak, Id),
                Godmode = Convert.ToBoolean(GetClassInfo<GmodeIndex>(Addresses.Classes.GodmodeClass1, Id)),
            };
        }

        private void SetClassInfo<T>(Addresses.Classes offsets, uint index, T value)
        {
            Extension.WriteByte((uint)offsets + (index * (uint)Addresses.Classes.ClassInterval), Convert.ToByte(value));
        }

        private void SetClassName(uint index, string name)
        {
            Extension.WriteString((uint)Addresses.Classes.ClassName1 + (index * (uint)Addresses.Classes.ClassInterval), name);
        }

        public void Set()
        {
            SetClassName(Id, Name);
            SetClassInfo(Addresses.Classes.PrimaryWeapon, Id, PrimaryWeapon);
            SetClassInfo(Addresses.Classes.PrimaryWeaponProficiency, Id, PrimaryWeaponProficiency);
            SetClassInfo(Addresses.Classes.PrimaryWeaponAttachment1, Id, PrimaryWeaponAttachment1);
            SetClassInfo(Addresses.Classes.PrimaryWeaponAttachment2, Id, PrimaryWeaponAttachment2);
            SetClassInfo(Addresses.Classes.PrimaryWeaponReticle, Id, PrimaryWeaponReticle);
            SetClassInfo(Addresses.Classes.PrimaryWeaponCamo, Id, PrimaryWeaponCamo);
            SetClassInfo(Addresses.Classes.SecondaryWeapon, Id, SecondaryWeapon);
            SetClassInfo(Addresses.Classes.SecondaryWeaponProficiency, Id, SecondaryWeaponProficiency);
            SetClassInfo(Addresses.Classes.SecondaryWeaponAttachment1, Id, SecondaryWeaponAttachment1);
            SetClassInfo(Addresses.Classes.SecondaryWeaponAttachment2, Id, SecondaryWeaponAttachment2);
            SetClassInfo(Addresses.Classes.SecondaryWeaponReticle, Id, SecondaryWeaponReticle);
            SetClassInfo(Addresses.Classes.SecondaryWeaponCamo, Id, SecondaryWeaponCamo);
            SetClassInfo(Addresses.Classes.Lethal, Id, Lethal);
            SetClassInfo(Addresses.Classes.Tactical, Id, Tactical);
            SetClassInfo(Addresses.Classes.Perk1, Id, Perk1);
            SetClassInfo(Addresses.Classes.Perk2, Id, Perk2);
            SetClassInfo(Addresses.Classes.Perk3, Id, Perk3);
            SetClassInfo(Addresses.Classes.StrikePackage, Id, StrikePackage);
            SetClassInfo(Addresses.Classes.Assault1, Id, Assault1);
            SetClassInfo(Addresses.Classes.Assault2, Id, Assault2);
            SetClassInfo(Addresses.Classes.Assault3, Id, Assault3);
            SetClassInfo(Addresses.Classes.Support1, Id, Support1);
            SetClassInfo(Addresses.Classes.Support2, Id, Support2);
            SetClassInfo(Addresses.Classes.Support3, Id, Support3);
            SetClassInfo(Addresses.Classes.Specialist1, Id, Specialist1);
            SetClassInfo(Addresses.Classes.Specialist2, Id, Specialist2);
            SetClassInfo(Addresses.Classes.Specialist3, Id, Specialist3);
            SetClassInfo(Addresses.Classes.Deathstreak, Id, Deathstreak);
            SetClassInfo(Addresses.Classes.GodmodeClass1, Id, Godmode ? GmodeIndex.Godmode : GmodeIndex.NONE);
        }
    }
}
