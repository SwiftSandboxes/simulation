using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(00005)]
    public class M_00005_AddSimSchedule : Migration
    {
        public override void Up()
        {
            Create.Table("SimSchedule")
                .WithColumn("SimScheduleId").AsInt32().PrimaryKey().Identity()
                .WithColumn("GameId").AsInt64();
        }

        public override void Down()
        {
            Delete.Table("Team");
        }
    }
}