﻿using System;
using System.Collections.Generic;

namespace Backend.Entities.Autogenerated;

public partial class ResidentialOfferDetail
{
    public int ResidentialOfferDetailsId { get; set; }

    public byte FkResidentialContractTypeId { get; set; }

    public int? FkResidentialLeasingDetailsId { get; set; }

    public int? FkResidentialSaleDetailsId { get; set; }

    public byte FkResidentialEstateTypeId { get; set; }

    public int? FkHouseDetails { get; set; }

    public int? FkRoomsDetails { get; set; }

    public int? FkFlatDetails { get; set; }

    public virtual FlatDetail? FkFlatDetailsNavigation { get; set; }

    public virtual HouseDetail? FkHouseDetailsNavigation { get; set; }

    public virtual ResidentialContractType FkResidentialContractType { get; set; } = null!;

    public virtual ResidentialEstateType FkResidentialContractTypeNavigation { get; set; } = null!;

    public virtual ResidentialLeaseDetail? FkResidentialLeasingDetails { get; set; }

    public virtual ResidentialSaleDetail? FkResidentialSaleDetails { get; set; }

    public virtual RoomsDetail? FkRoomsDetailsNavigation { get; set; }

    public virtual ICollection<Offer> Offers { get; set; } = new List<Offer>();
}
