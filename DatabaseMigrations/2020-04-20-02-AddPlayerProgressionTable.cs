using FluentMigrator;

namespace simulation.DatabaseMigrations
{
    [Migration(2020042002)]
    public class Migration2020042002 : Migration
    {
        public override void Up()
        {
            Create.Table("PlayerProgressionModel")
                .WithColumn("PlayerProgressionModelId").AsInt64().PrimaryKey().Identity()
                .WithColumn("AppearanceModification").AsString()                

                .WithColumn("Assist").AsString()
                .WithColumn("AssistDefense").AsString()     //defensive awareness
                .WithColumn("Block").AsString()          
                .WithColumn("BlockDefense").AsString()      //creativity, elusiveness
                .WithColumn("Endurance").AsString()         //minutes per game
                .WithColumn("Foul").AsString()
                .WithColumn("FoulDefense").AsString()       //ability to draw fouls
                .WithColumn("FreeThrow").AsString()         //free throw percentage
                .WithColumn("Rebound").AsString()           //offensive rebounding
                .WithColumn("ReboundDefense").AsString()    //defensive rebounding
                .WithColumn("Shot").AsString()              //shooting percentage
                .WithColumn("ShotDefense").AsString()       //on ball defense
                .WithColumn("Steal").AsString()
                .WithColumn("StealDefense").AsString()      //ballhandling
                .WithColumn("ThreePointShot").AsString()    //3pt shooting percentage
                .WithColumn("ThreePointRate").AsString()    //3pt vs 2pt shots
                .WithColumn("Turnover").AsString()           
                .WithColumn("TurnoverDefense").AsString()   //ballhandling
                .WithColumn("UsageRate").AsString();        //ball-stopper-ness
        }

        public override void Down()
        {
            Delete.Table("PlayerProgressionModel");
        }
    }
}