using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(00003)]
    public class M_00003_AddTeam : Migration
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