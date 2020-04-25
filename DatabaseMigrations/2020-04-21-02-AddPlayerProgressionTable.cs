using FluentMigrator;

namespace bballsim.league.simulation.DatabaseMigrations
{
    [Migration(2020042102)]
    public class M_2020_04_21_02_AddPlayerProgression : Migration
    {
        public override void Up()
        {
            Create.Table("PlayerProgression")
                .WithColumn("PlayerProgressionId").AsInt32().PrimaryKey().Identity()
                .WithColumn("PlayerProgressionModelId").AsInt32()   //make this a foreign key to PlayerProgressionModel
                .WithColumn("Age").AsInt32()
                
                .WithColumn("Appearance").AsString()        //modifications to appearance, thicker beard, grey hair, hair loss, etc

                //The following are adjustment values (+ or -), depending on the players age.
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
            Delete.Table("PlayerProgression");
        }
    }
}