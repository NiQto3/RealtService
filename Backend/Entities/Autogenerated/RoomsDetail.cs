﻿using System;
using System.Collections.Generic;

namespace Backend.Entities.Autogenerated;

public partial class RoomsDetail
{
    public int RoomsDetailsId { get; set; }

    public float? Square { get; set; }

    public short? FloorNumber { get; set; }

    public short? RoomNumber { get; set; }

    public virtual ICollection<ResidentialOfferDetail> ResidentialOfferDetails { get; set; } = new List<ResidentialOfferDetail>();
}
