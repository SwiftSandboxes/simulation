using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(2020042404)]
    public class M_2020_04_24_04_AddGamePlayerStat : Migration
    {
        public override void Up()
        {
            Create.Table("GamePlayerStat")
                .WithColumn("GamePlayerStatId").AsInt64().PrimaryKey().Identity()
                .WithColumn("GameId").AsInt64()
                .WithColumn("PlayerId").AsInt64()

                .WithColumn("Assists").AsInt32()
                .WithColumn("Fouls").AsInt32()
                .WithColumn("Blocks").AsInt32()
                .WithColumn("ReboundsDefensive").AsInt32()                
                .WithColumn("ReboundsOffensive").AsInt32()
                .WithColumn("Steals").AsInt32()
                .WithColumn("Turnovers").AsInt32()

                .WithColumn("Attempts2pt").AsInt32()
                .WithColumn("Attempts3pt").AsInt32()
                .WithColumn("AttemptsFreeThrow").AsInt32()

                .WithColumn("Makes2pt").AsInt32()
                .WithColumn("Makes3pt").AsInt32()
                .WithColumn("MakesFreeThrow").AsInt32()

                .WithColumn("TenthsOfSecondsPlayed").AsInt64();
        }

        public override void Down()
        {
            Delete.Table("Team");
        }
    }
}