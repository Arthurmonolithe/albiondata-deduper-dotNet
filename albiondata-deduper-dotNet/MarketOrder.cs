﻿using System;
using System.Collections.Generic;
using System.Text;

namespace albiondata_deduper_dotNet
{
  internal class MarketOrder
  {
    public static string MarketOrdersIngest = "marketorders.ingest";
    public static string MarketOrdersDeduped = "marketorders.dedupedtest";

    public long Id;
    public string ItemTypeId;
    public string ItemGroupTypeId;
    public int LocationId;
    public int QualityLevel;
    public int EnchantmentLevel;
    public long UnitPriceSilver;
    public long Amount;
    public string AuctionType;
    public string Expires;

    public override string ToString()
    {
      return $"{Id}{Amount}";
    }
  }

  internal class MarketUpload
  {
    public List<MarketOrder> Orders = new List<MarketOrder>();
  }
}
