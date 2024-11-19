﻿using System;
using System.Collections.Generic;

namespace Lab2proj.Models1;

public partial class ParkingSpace
{
    public int Id { get; set; }

    public bool IsPenalty { get; set; }

    public int? CarId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}