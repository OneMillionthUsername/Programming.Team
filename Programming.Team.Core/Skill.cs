﻿using System;
using System.Collections.Generic;

namespace Programming.Team.Core;

public partial class Skill : Entity<Guid>
{

    public string Name { get; set; } = null!;

    public virtual ICollection<PositionSkill> PositionSkills { get; set; } = new List<PositionSkill>();
}
