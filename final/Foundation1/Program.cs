using System;

class Program
{
    static void Main(string[] args)
    {
        Comment unbox1 = new Comment("@museumcurator224", "Indiana Jones, you leave that mummy alone!!!");
        Comment unbox2 = new Comment("@PraisethePharaoh", "Unhand the Pharaoh, heathen, or you shall be cursed!  Cursed, I say!!!");
        Comment unbox3 = new Comment("@TheRealPharaoh", "Thanks for getting me out of that thing!");
        List<Comment> unboxComments = new List<Comment>() {unbox1,unbox2, unbox3};
        Video unboxing = new Video("Sarcophagus Unboxing", "@TheRealIndyJones", "24:35", unboxComments);

        Comment minecraft1 = new Comment("@carlthepumpkin", "First!");
        Comment minecraft2 = new Comment("@Ninjad", "First!");
        Comment minecraft3 = new Comment("@S4ladFork", "Way to go Oinki, congrats on making it this far!");
        List<Comment> minecraftComments = new List<Comment>() {minecraft1,minecraft2,minecraft3};
        Video minecraft = new Video("Minecraft Let's  Play - Ep. 43: Challenging the Nether", "@OinkiSpoinky", "28:20", minecraftComments);

        Comment cooking1 = new Comment("@bagelwches", "Delicious!");
        Comment cooking2 = new Comment("@Weiksrs", "Are you sure this is safe?");
        Comment cooking3 = new Comment("@Bakr1na_perx", "Day 17 of asking you to make whipped cream on the wing of a plane mid-flight");
        List<Comment> cookingComments = new List<Comment>() {cooking1,cooking2,cooking3};
        Video cooking = new Video("Making Creme Brulee with a Portable Nuclear Reactor!", "@Chef_Einstein", "15:47", cookingComments);

        List<Video> videos = new List<Video>{unboxing,minecraft,cooking};

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }

    }
}