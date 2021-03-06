﻿using Mods.ModsList;
using Ship;
using SubPhases;
using System;
using System.Collections.Generic;
using Upgrade;

namespace Ship
{
    namespace SecondEdition.RZ1AWing
    {
        public class AhsokaTano : RZ1AWing
        {
            public AhsokaTano() : base()
            {
                PilotInfo = new PilotCardInfo(
                    "Ahsoka Tano",
                    5,
                    49,
                    isLimited: true,
                    abilityType: typeof(Abilities.SecondEdition.AhsokaTanoRebelAbility),
                    extraUpgradeIcons: new List<UpgradeType>() { UpgradeType.ForcePower, UpgradeType.ForcePower },
                    force: 3,
                    abilityText: "After you fully execute a maneuver, you may choose a friendly ship at range 0-1 and spend 1 Force. That ship may perform an action, even if it is stressed."
                );

                PilotNameCanonical = "ahsokatano-rz1awing";

                ModelInfo.SkinName = "Blue";

                ImageUrl = "https://images-cdn.fantasyflightgames.com/filer_public/f2/84/f284aa2b-9e09-4c3c-968b-935360a65edc/swz83_pilot_ahsokatano.png";
            }
        }
    }
}

namespace Abilities.SecondEdition
{
    public class AhsokaTanoRebelAbility: AhsokaTanoAbility
    {
        protected override int ForceCost => 2;
        protected override int MinRange => 1;
        protected override int MaxRange => 2;
    }
}