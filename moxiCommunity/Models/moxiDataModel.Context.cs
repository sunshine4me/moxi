﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace moxiCommunity.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class moxiAgentBuyEntities : DbContext
{
    public moxiAgentBuyEntities()
        : base("name=moxiAgentBuyEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<BuyDemand> BuyDemand { get; set; }

    public virtual DbSet<BuySolution> BuySolution { get; set; }

    public virtual DbSet<CommunityUser> CommunityUser { get; set; }

    public virtual DbSet<Topic> Topic { get; set; }

    public virtual DbSet<TopicReply> TopicReply { get; set; }

}

}

