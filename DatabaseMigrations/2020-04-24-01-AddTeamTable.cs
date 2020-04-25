using FluentMigrator;

namespace bballsim.league.simulation.DatabaseMigrations
{
    [Migration(2020042401)]
    public class M_2020_04_24_01_AddTeam : Migration
    {
        public override void Up()
        {
            Create.Table("Team")
                .WithColumn("TeamId").AsInt32().PrimaryKey().Identity()
                .WithColumn("TeamName").AsString()
                .WithColumn("HomeAreaName").AsString()
                .WithColumn("HomeAreaCapacity").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("Team");
        }
    }
}