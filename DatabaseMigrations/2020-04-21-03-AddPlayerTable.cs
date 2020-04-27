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
                .WithColumn("PlayerProgressionModelId").AsInt32()   //model for player improvement/decline
                
                .WithColumn("Assist").AsInt32()
                .WithColumn("AssistDefense").AsInt32()      //defensive awareness, team defense
                .WithColumn("Block").AsInt32()          
                .WithColumn("BlockDefense").AsInt32()       //creativity, elusiveness
                .WithColumn("Endurance").AsInt32()          //minutes per game
                .WithColumn("Foul").AsInt32()
                .WithColumn("FoulDefense").AsInt32()        //ability to draw fouls
                .WithColumn("FreeThrow").AsInt32()          //free throw percentage
                .WithColumn("Rebound").AsInt32()            //offensive rebounding
                .WithColumn("ReboundDefense").AsInt32()     //defensive rebounding
                .WithColumn("Shot").AsInt32()               //shooting percentage
                .WithColumn("ShotDefense").AsInt32()        //on ball defense
                .WithColumn("Steal").AsInt32()
                .WithColumn("StealDefense").AsInt32()       //ballhandling
                .WithColumn("ThreePointShot").AsInt32()     //3pt shooting percentage
                .WithColumn("ThreePointRate").AsInt32()     //3pt vs 2pt shot preference
                .WithColumn("Turnover").AsInt32()           
                .WithColumn("TurnoverDefense").AsInt32()    //ballhandling
                .WithColumn("UsageRate").AsInt32();         //ball-stopper-ness
        }

        public override void Down()
        {
            Delete.Table("Player");
        }
    }
}