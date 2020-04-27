using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(2020042403)]
    public class M_2020_04_24_03_AddSimSchedule : Migration
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