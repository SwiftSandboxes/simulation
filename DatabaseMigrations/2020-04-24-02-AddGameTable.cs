using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(2020042402)]
    public class M_2020_04_24_02_AddGame : Migration
    {
        public override void Up()
        {
            Create.Table("Game")
                .WithColumn("GameId").AsInt64().PrimaryKey().Identity()
                .WithColumn("HomeTeamId").AsInt32()
                .WithColumn("AwayTeamId").AsInt32()
                .WithColumn("GameDate").AsDate()
                .WithColumn("Attendance").AsInt32()
                .WithColumn("TotalMinutes").AsInt32()
                .WithColumn("HomeTeamScore").AsInt32()
                .WithColumn("AwayTeamScore").AsInt32()
                .WithColumn("HomeTeamWonInd").AsBoolean()
                .WithColumn("PlayByPlay").AsString();
        }

        public override void Down()
        {
            Delete.Table("Team");
        }
    }
}