﻿using System.Data;
using Abp.Zero.FluentMigrator;
using FluentMigrator;

namespace Taskever.Data.Migrations.V20131007
{
    [Migration(2013100701)]
    public class _01_CreateTeActivitiesTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("TeActivities")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey().Identity()
                .WithColumn("ActivityType").AsInt32().NotNullable()
                .WithUserId("CreatorUserId")
                .WithUserId("AssignedUserId")
                .WithColumn("TaskId").AsInt32().Nullable().ForeignKey("TeTasks", "Id").OnDelete(Rule.Cascade)
                .WithColumn("CreationTime").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        }
    }
}
