using System.ComponentModel;

namespace RankTest.Core
{
    public enum WeaponIndex
    {
        [Description("None")]
        NONE,
        [Description("USP .45")]
        USP_TACTICAL,
        [Description("MP412")]
        MP412,
        [Description("44 MAGNUM")]
        MAGNUM_44,
        [Description("DESERT EAGLE")]
        DESERT_EAGLE,
        [Description("P99")]
        P99,
        [Description("FIVE SEVEN")]
        FIVE_SEVEN,
        [Description("ACR 6.8")]
        ACR_68,
        [Description("TYPE 958")]
        Type_95,
        [Description("M4A1")]
        M4A1,
        [Description("AK-47")]
        AK_47,
        [Description("M16A4")]
        M16A4,
        [Description("MK14")]
        MK14,
        [Description("CM901")]
        CM_901,
        [Description("G36C")]
        G36C,
        [Description("SCAR-L")]
        SCAR_L,
        [Description("FAD")]
        FAD,
        [Description("MP5")]
        MP5,
        [Description("PM-9")]
        PM_9,
        [Description("P90")]
        P90,
        [Description("PP90M1")]
        PP90M1,
        [Description("UMP45")]
        UMP45,
        [Description("MP7")]
        MP7,
        [Description("FMG9")]
        FMG9,
        [Description("G18")]
        G18,
        [Description("MP9")]
        MP9,
        [Description("SKORPION")]
        SKORPION,
        [Description("SPAS-12")]
        SPAS_12 = 0x1C,
        [Description("AA-12")]
        AA_12,
        [Description("STRIKER")]
        STRIKER,
        [Description("MODEL 1887")]
        MODEL_1887,
        [Description("USAS 12")]
        USAS_12,
        [Description("KSG 12")]
        KSG_12,
        [Description("M60E4")]
        M60E4,
        [Description("MK46")]
        MK46,
        [Description("PKP PECHENEG")]
        PKP_PECHENEG,
        [Description("L86 LSW")]
        L86_LSW,
        [Description("MG36")]
        MG36,
        [Description("BARRETT 50CAL")]
        BARRETT_50,
        [Description("MSR")]
        MSR,
        [Description("RSASS")]
        RSASS,
        [Description("DRAGUNOV")]
        DRAGUNOV,
        [Description("AS50")]
        AS50,
        [Description("L188A")]
        L118A,
        [Description("RPG-7")]
        RPG_7 = 0x2E,
        [Description("JAVELIN")]
        JAVELIN = 0x35,
        [Description("STINGER")]
        STINGER,
        [Description("SMAW")]
        SMAW,
        [Description("M320 GLM")]
        M320_GLM,
        [Description("RIOT SHIELD")]
        RIOT_SHIELD = 0x3F,
        [Description("XM25")]
        XM25 = 0x42,
        [Description("AUG H-BAR")]
        AUGH_BAR = 0x5A
    }

    public enum PrimWeaponIndex
    {
        [Description("None")]
        NONE,
        [Description("ACR 6.8")]
        ACR_68 = 7,
        [Description("TYPE 95")]
        Type_95,
        [Description("M4A1")]
        M4A1,
        [Description("AK-47")]
        AK_47,
        [Description("M16A4")]
        M16A4,
        [Description("MK14")]
        MK14,
        [Description("CM901")]
        CM_901,
        [Description("G36C")]
        G36C,
        [Description("SCAR-L")]
        SCAR_L,
        [Description("FAD")]
        FAD,
        [Description("MP5")]
        MP5,
        [Description("PM-9")]
        PM_9,
        [Description("P90")]
        P90,
        [Description("PP90M1")]
        PP90M1,
        [Description("UMP45")]
        UMP45,
        [Description("MP7")]
        MP7,
        [Description("SPAS-12")]
        SPAS_12 = 0x1C,
        [Description("AA-12")]
        AA_12,
        [Description("STRIKER")]
        STRIKER,
        [Description("MODEL 1887")]
        MODEL_1887,
        [Description("USAS 12")]
        USAS_12,
        [Description("KSG 12")]
        KSG_12,
        [Description("M60E4")]
        M60E4,
        [Description("MK46")]
        MK46,
        [Description("PKP PECHENEG")]
        PKP_PECHENEG,
        [Description("L86 LSW")]
        L86_LSW,
        [Description("MG36")]
        MG36,
        [Description("BARRETT 50CAL")]
        BARRETT_50,
        [Description("MSR")]
        MSR,
        [Description("RSASS")]
        RSASS,
        [Description("DRAGUNOV")]
        DRAGUNOV,
        [Description("AS50")]
        AS50,
        [Description("L118A")]
        L118A,
        [Description("RIOT SHIELD")]
        RIOT_SHIELD = 0x3F,
        [Description("AUG H-BAR")]
        AUGH_BAR = 0x5A
    }

    public enum SecWeaponIndex
    {
        [Description("None")]
        NONE,
        [Description("USP .45")]
        USP_TACTICAL,
        [Description("MP412")]
        MP412,
        [Description("44 MAGNUM")]
        MAGNUM_44,
        [Description("DESERT EAGLE")]
        DESERT_EAGLE,
        [Description("P99")]
        P99,
        [Description("FIVE SEVEN")]
        FIVE_SEVEN,
        [Description("FMG9")]
        FMG9 = 23,
        [Description("G18")]
        G18,
        [Description("MP9")]
        MP9,
        [Description("SKORPION")]
        SKORPION,
        [Description("RPG-7")]
        RPG_7 = 0X2E,
        [Description("JAVELIN")]
        JAVELIN = 0X35,
        [Description("STINGER")]
        STINGER,
        [Description("SMAW")]
        SMAW,
        [Description("M320 GLM")]
        M320_GLM,
        [Description("XM25")]
        XM25 = 0X42,
        [Description("AUG H-BAR")]
        AUGH_BAR = 0X5A
    }

    public enum Proficiencies
    {
        [Description("None")]
        NONE,
        [Description("SPEED")]
        SPEED = 0X23,
        [Description("ATTACHMENTS")]
        ATTACHMENTS = 0X39,
        [Description("IMPACT")]
        IMPACT = 0X84,
        [Description("KICK")]
        KICK,
        [Description("FOCUS")]
        FOCUS,
        [Description("BREATH")]
        BREATH = 0X88,
        [Description("RANGE")]
        RANGE,
        [Description("MELEE")]
        MELEE,
        [Description("STABILITY")]
        STABILITY,
        [Description("DAMAGE")]
        DAMAGE
    }

    public enum Attachments
    {
        [Description("None")]
        NONE,
        [Description("Red Dot Sight")]
        RED_DOT_SIGHT,
        [Description("ACOG Scope")]
        ACOG_SCOPE,
        [Description("Grip")]
        GRIP,
        [Description("Akimbo")]
        AKIMBO,
        [Description("Thermal")]
        THERMAL,
        [Description("Shotgun")]
        SHOTGUN,
        [Description("Heatbeat Sensor")]
        HEATBEAT_SENSOR,
        [Description("Extended Mags")]
        EXTENDED_MAGS = 0X09,
        [Description("Rapid Fire")]
        RAPID_FIRE,
        [Description("Holographic Sight")]
        HOLOGRAPHIC_SIGHT,
        [Description("Tactical Knife")]
        TACTICAL_KNIFE,
        [Description("Variable Zoom Scope")]
        VARIABLE_ZOOM_SCOPE,
        [Description("Grenade Launcher")]
        GRENADE_LAUNCHER,
        [Description("Silencer")]
        SILENCER = 0X11,
        [Description("HAMR Scope")]
        HAMR_SCOPE = 0X13,
        [Description("Hubrid Sight")]
        HYBRID_SIGHT = 0X15
    }

    public enum Camos
    {
        [Description("None")]
        NONE,
        [Description("Classic")]
        CLASSIC,
        [Description("Snow")]
        SNOW,
        [Description("Multicam")]
        MULTICAM,
        [Description("Digital Urban")]
        DIGITAL_URBAN,
        [Description("HEX")]
        HEX,
        [Description("Choco")]
        CHOCO,
        [Description("Marine")]
        MARINE,
        [Description("Snake")]
        SNAKE,
        [Description("Winter")]
        WINTER,
        [Description("Blue")]
        BLUE,
        [Description("Red")]
        RED,
        [Description("Autumn")]
        AUTUMN,
        [Description("Gold")]
        GOLD
    }

    public enum Reticle
    {
        [Description("None")]
        NONE,
        [Description("Target DOT")]
        TARGET_DOT,
        [Description("Delta")]
        DELTA,
        [Description("U-DOT")]
        U_DOT,
        [Description("MIL-DOT")]
        MIL_DOT,
        [Description("Omega")]
        OMEGA,
        [Description("Lambda")]
        LAMBDA
    }

    public enum Lethal
    {
        [Description("None")]
        NONE,
        [Description("C4")]
        C4 = 0X65,
        [Description("CLAYMORE")]
        CLAYMORE,
        [Description("THROWING KNIFE")]
        THROWING_KNIFE = 0X6A,
        [Description("SEMTEX")]
        SEMTEX,
        [Description("FRAG")]
        FRAG,
        [Description("BOUNCING BETTY")]
        BOUNCING_BETTY,
    }

    public enum Tactical
    {
        [Description("None")]
        NONE,
        [Description("SCRAMBLER")]
        SCRAMBLER = 0X4B,
        [Description("PORTABLE RADAR")]
        PORTABLE_RADAR,
        [Description("FLASH GRENADE")]
        FLASH_GRENADE = 0X6E,
        [Description("SMOKE GRENADE")]
        SMOKE_GRENADE,
        [Description("CONCUSSION GRENADE")]
        CONCUSSION_GRENADE,
        [Description("TROPHY SYSTEL")]
        TROPHY_SYSTEM = 0X72,
        [Description("EMP GRENADE")]
        EMP_GRENADE = 0X75,
        [Description("TACTICAL INSERTION")]
        TACTICAL_INSERTION = 0X83
    }

    public enum Perks
    {
        [Description("None")]
        NONE,
        [Description("Dead Silence")]
        DEAD_SILENCE = 0X08,
        [Description("Extreme Conditioning")]
        EXTREME_CONDITIONING,
        [Description("Sitrep")]
        SITREP,
        [Description("Steady Aim")]
        STEADY_AIM = 0X0C,
        [Description("Sleight of Hand")]
        SLEIGHT_OF_HAND = 0X0F,
        [Description("Overkill")]
        OVERKILL = 0X11,
        [Description("Quickdraw")]
        QUICKDRAW = 0X26,
        [Description("Scavenger")]
        SCAVENGER = 0X2B,
        [Description("Assassin")]
        ASSASSIN = 0X30,
        [Description("Blind Eye")]
        BLIND_EYE,
        [Description("Hardline")]
        HARDLINE = 0X44,
        [Description("Stalker")]
        STALKER = 0X4A,
        [Description("Blast Shield")]
        BLAST_SHIELD = 0X4E,
        [Description("Recon")]
        RECON = 0X5C,
        [Description("Marksman")]
        MARKSMAN = 0X94,
    }

    public enum Perks1
    {
        [Description("None")]
        NONE,
        [Description("Extreme Conditioning")]
        EXTREME_CONDITIONING = 0x09,
        [Description("Sleight of Hand")]
        SLEIGHT_OF_HAND = 0X0F,
        [Description("Scavenger")]
        SCAVENGER = 0X2B,
        [Description("Blind Eye")]
        BLIND_EYE = 0x31,
        [Description("Recon")]
        RECON = 0X5C,
    }

    public enum Perks2
    {
        [Description("None")]
        NONE,
        [Description("Overkill")]
        OVERKILL = 0X11,
        [Description("Quickdraw")]
        QUICKDRAW = 0X26,
        [Description("Assassin")]
        ASSASSIN = 0X30,
        [Description("Hardline")]
        HARDLINE = 0X44,
        [Description("Blast Shield")]
        BLAST_SHIELD = 0X4E,
    }

    public enum Perks3
    {
        [Description("None")]
        NONE,
        [Description("Dead Silence")]
        DEAD_SILENCE = 0X08,
        [Description("Sitrep")]
        SITREP = 10,
        [Description("Steady Aim")]
        STEADY_AIM = 0X0C,
        [Description("Stalker")]
        STALKER = 0X4A,
        [Description("Marksman")]
        MARKSMAN = 0X94,
    }

    public enum StrikePackage
    {
        [Description("None")]
        NONE,
        [Description("Assault")]
        ASSAULT = 0X5E,
        [Description("Support")]
        SUPPORT = 0X5F,
        [Description("Specialist")]
        SPECIALIST = 0X61,
    }

    public enum Assault
    {
        [Description("None")]
        NONE,
        [Description("UAV")]
        UAV,
        [Description("Care Package")]
        CARE_PACKAGE,
        [Description("Predator Missile")]
        PREDATOR_MISSILE,
        [Description("I.M.S")]
        IMS,
        [Description("Sentry Gun")]
        SENTRY_GUN,
        [Description("Precision Airstrike")]
        PRECISION_AIRSTIKE = 0X07,
        [Description("Attack Helicopter")]
        ATTACK_HELICOPTER,
        [Description("Strafe Run")]
        STRAFE_RUN,
        [Description("AH-6 Overwatch")]
        AH6_OVERWATCH,
        [Description("Reaper")]
        REAPER,
        [Description("Assault Drone")]
        ASSAULT_DRONE,
        [Description("Pave Low")]
        PAVE_LOW = 0X0E,
        [Description("AC130")]
        AC130,
        [Description("Juggernaut")]
        JUGGERNAUT,
        [Description("Osprey Gunner")]
        OSPREY_GUNNER = 0X12
    }

    public enum Support
    {
        [Description("None")]
        NONE,
        [Description("UAV")]
        UAV = 0X13,
        [Description("Counter UAV")]
        COUNTER_UAV,
        [Description("Ballistic Vests")]
        BALLISTIC_VESTS,
        [Description("Airdrop Trap")]
        AIRDROP_TRAP,
        [Description("Sam Turret")]
        SAM_TURRET,
        [Description("Recon Drone")]
        RECON_DRONE,
        [Description("Advanced UAV")]
        ADVANCED_UAV,
        [Description("Remote Turret")]
        REMOTE_TURRET,
        [Description("Stealth Bomber")]
        STEALTH_BOMBER,
        [Description("EMP")]
        EMP,
        [Description("Juggernaut Recon")]
        JUGGERNAUT_RECON,
        [Description("Escort Airdrop")]
        ESCORT_AIRDROP = 0X1F
    }

    public enum Specialist
    {
        [Description("None")]
        NONE,
        [Description("Extreme Conditionning")]
        EXTREME_CONDITIONING = 0X21,
        [Description("Sleight of Hand")]
        SLEIGHT_OF_HAND,
        [Description("Scavenger")]
        SCAVENGER,
        [Description("Blind Eye")]
        BLIND_EYE,
        [Description("Recon")]
        RECON,
        [Description("Hardline")]
        HARDLINE,
        [Description("Assassin")]
        ASSASSIN,
        [Description("Quickdraw")]
        QUICKDRAW,
        [Description("Blast Shield")]
        BLAST_SHIELD = 0X2A,
        [Description("Sitrep")]
        SITREP,
        [Description("Marksman")]
        MARKSMAN,
        [Description("Steady Aim")]
        STEADY_AIM,
        [Description("Dead Silence")]
        DEAD_SILENCE,
        [Description("Stalker")]
        STALKER
    }

    public enum Deathstreaks
    {
        [Description("None")]
        NONE,
        [Description("Juiced")]
        JUICED = 0X76,
        [Description("Martyrdom")]
        MARTYRDOM,
        [Description("Final Stand")]
        FINAL_STAND,
        [Description("Revenge")]
        REVENGE = 0X7C,
        [Description("Dead Man's Hand")]
        DEAD_MAN_S_SHEAD,
        [Description("Hollow Points")]
        HOLLOW_POINTS
    }

    public enum GmodeIndex
    {
        [Description("None")]
        NONE,
        [Description("Godmode")]
        Godmode = 0x6B
    }

    public enum StatsType
    {
        [Description("Online")]
        Online,
        [Description("Split screen")]
        SplitScreen
    }
}
