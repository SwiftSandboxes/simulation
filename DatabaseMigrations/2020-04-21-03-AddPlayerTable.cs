using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(2020042103)]
    public class M_2020_04_21_03_AddPlayer : Migration
    {
        public override void Up()
        {
            Create.Table("Player")
                .WithColumn("PlayerId").AsInt64().PrimaryKey().Identity()
                .WithColumn("Appearance").AsString()
                .WithColumn("BirthDate").AsDate()
                .WithColumn("College").AsString()
                .WithColumn("FirstName").AsString()
                .WithColumn("HeightInCm").AsInt32()
                .WithColumn("HomeTown").AsString()
                .WithColumn("LastName").AsString()
                .WithColumn("WeightInGrams").AsInt32()
                .WithColumn("Experience").AsInt32()
                .WithColumn("ScoutingDescription").AsString(4000)
                //.WithColumn("PlayerProgressionModelId").AsInt32()   //model for player improvement/decline
                
                .WithColumn("Assist").AsString(5)
                .WithColumn("AssistDefense").AsString(5)      //defensive awareness, team defense
                .WithColumn("Block").AsString(5)          
                .WithColumn("BlockDefense").AsString(5)       //creativity, elusiveness
                .WithColumn("Endurance").AsString(5)          //minutes per game
                .WithColumn("Foul").AsString(5)
                .WithColumn("FoulDefense").AsString(5)        //ability to draw fouls
                .WithColumn("FreeThrow").AsString(5)          //free throw percentage
                .WithColumn("Rebound").AsString(5)            //offensive rebounding
                .WithColumn("ReboundDefense").AsString(5)     //defensive rebounding
                .WithColumn("Shot").AsString(5)               //shooting percentage
                .WithColumn("ShotDefense").AsString(5)        //on ball defense
                .WithColumn("Steal").AsString(5)
                .WithColumn("StealDefense").AsString(5)       //ballhandling
                .WithColumn("ThreePointShot").AsString(5)     //3pt shooting percentage
                .WithColumn("ThreePointRate").AsString(5)     //3pt vs 2pt shot preference
                .WithColumn("Turnover").AsString(5)           
                .WithColumn("TurnoverDefense").AsString(5)    //ballhandling
                .WithColumn("UsageRate").AsString(5);         //ball-stopper-ness
        }

        public override void Down()
        {
            Delete.Table("Player");
        }
    }
}