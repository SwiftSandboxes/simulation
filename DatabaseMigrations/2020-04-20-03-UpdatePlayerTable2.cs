using FluentMigrator;

namespace simulation.DatabaseMigrations
{
    [Migration(2020042003)]
    public class Migration2020042003 : Migration
    {
        public override void Up()
        {
            Delete.Table("Player");

            Create.Table("Player")
                .WithColumn("PlayerId").AsInt64().PrimaryKey().Identity()
                .WithColumn("Appearance").AsString()
                .WithColumn("BirthDate").AsDate()
                .WithColumn("FirstName").AsString()
                .WithColumn("LastName").AsString()
                .WithColumn("PlayerProgressionModelId").AsInt32()   //model for player improvement/decline
                
                .WithColumn("Assist").AsInt32()
                .WithColumn("AssistDefense").AsInt32()      //defensive awareness
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
                .WithColumn("ThreePointRate").AsInt32()     //3pt vs 2pt shots
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