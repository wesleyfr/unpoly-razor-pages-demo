namespace webapp.Models;

public static class CandiesFakeData
{
    private static readonly Random Random = new Random(1234);

    public static void CreateRandomFakeCandies()
    {
        var commentsTaken = 0;
        foreach (var name in CandiesFakeData.Names)
        {
            var nbComments = Random.Next(6, 10);
            CandiesRepository.AddCandy(name, comments: Comments.Skip(commentsTaken).Take(nbComments).ToList());
            commentsTaken += nbComments;
        }
    }
    
    private static readonly string[] Comments =
    {
        "J'adore le goût sucré du caramel dans ces bonbons !",
        "Je n'aime pas la texture caoutchouteuse des bonbons gélifiés.",
        "Ces chocolats sont un délice divin !",
        "Je ne suis pas fan des bonbons au goût de réglisse.",
        "La croquant de ces bonbons est tellement satisfaisant !",
        "Trop de sucre dans ces bonbons à mon goût.",
        "J'adore les saveurs fruitées de ces bonbons mous.",
        "Les bonbons à la menthe sont rafraîchissants et agréables.",
        "La combinaison de chocolat et de noix est divine !",
        "Les bonbons acidulés font danser mes papilles gustatives de joie.",
        "Ces bonbons durs rappellent des souvenirs d'enfance.",
        "Je ne suis pas fan de la saveur de noix de coco dans ces bonbons.",
        "Ces bonbons sont parfaits pour un regain d'énergie rapide.",
        "Je n'aime pas l'arrière-goût de certains édulcorants artificiels.",
        "Les bonbons à mâcher se coincent entre mes dents, pas fan.",
        "J'adore la variété dans ce pack de bonbons assortis !",
        "Ces bonbons sont trop épicés pour mon goût.",
        "Le chocolat noir est mon préféré absolu !",
        "Ces bonbons sont trop acidulés pour mes papilles gustatives.",
        "La garniture de caramel dans ces bonbons est trop collante.",
        "Beurre de cacahuète et chocolat - une alliance divine !",
        "Trop de colorants artificiels dans ces bonbons.",
        "Je rêve de la bonté crémeuse de ces truffes au chocolat.",
        "Je ne suis pas fan de la texture craquante de certains bonbons.",
        "L'explosion de saveurs fruitées dans ces bonbons est délicieuse.",
        "Ces bonbons sont trop durs et font mal à mes dents.",
        "Les bonbons aux noix sont la meilleure collation !",
        "Je n'aime pas la collanté de certains bonbons à mâcher.",
        "Ces bonbons sont un plaisir coupable pour moi.",
        "La combinaison de sucré et salé est parfaite !",
        "Ces bonbons ont un goût trop artificiel pour moi.",
        "Les bonbons à la cerise sont mes préférés de tous les temps !",
        "Je n'aime pas le revêtement cireux de certains bonbons au chocolat.",
        "Ces bonbons sont parfaits pour une soirée cinéma !",
        "Pas fan des réglisses torsadées dans cet assortiment.",
        "J'adore le goût nostalgique de ces bonbons classiques.",
        "Ces bonbons sont trop fades et manquent de saveur.",
        "L'arôme fruité de ces bonbons est irrésistible.",
        "Je n'aime pas la texture croquante des bonbons durs.",
        "Le caramel dans ces bonbons est trop collant.",
        "Ces bonbons sont une explosion de bonheur dans ma bouche !",
        "Pas fan des saveurs de fruits artificiels.",
        "La saveur caramel au beurre salé est une révélation !",
        "Je n'aime pas la douceur excessive de certains bonbons.",
        "Ces bonbons sont une délicieuse friandise après un repas.",
        "Pas fan de la texture trop mâchée.",
        "La combinaison de sucré et acidulé est parfaite !",
        "Ces bonbons me ramènent aux souvenirs des vacances d'été.",
        "Trop de saveur de noix de coco dans ces bonbons.",
        "Ces bonbons sont parfaits pour partager avec des amis.",
        "Pas fan des bonbons durs qui prennent une éternité à fondre.",
        "J'adore le croustillant du sucre caramélisé dans ces friandises !",
        "Ces bonbons sont un peu trop collants à mon goût.",
        "L'acidité dans ces bonbons est juste parfaite !",
        "Pas fan de l'arrière-goût d'édulcorant artificiel.",
        "Ces bonbons sont parfaits pour une pause pendant le travail.",
        "Le revêtement chocolaté de ces bonbons est trop fin.",
        "Ces bonbons sont une explosion de joie à chaque bouchée !",
        "Pas fan du centre trop mou dans certains chocolats.",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Ces bonbons sont une escapade sucrée de la réalité.",
        "La combinaison de caramel et de chocolat est irrésistible !",
        "Je n'aime pas l'arrière-goût artificiel dans ces bonbons.",
        "Ces bonbons sont un excellent compagnon lors de longs trajets.",
        "Pas fan des bonbons durs qui restent collés à mes dents.",
        "Le mélange de saveurs dans ces bonbons est tout simplement divin !",
        "Ces bonbons sont parfaits pour une soirée douillette.",
        "Pas fan des réglisses torsadées dans cet assortiment.",
        "J'adore la bonté fondante de ces truffes au chocolat !",
        "Le croquant de ces bonbons est tellement satisfaisant !",
        "Ces bonbons sont trop épicés pour mon goût.",
        "Je ne suis pas fan des bonbons à la réglisse.",
        "La combinaison de sucre et de sel est parfaite !",
        "Ces bonbons ont un goût trop artificiel pour moi.",
        "Les bonbons à la cerise sont mes préférés de tous les temps !",
        "Je n'aime pas le revêtement cireux de certains bonbons au chocolat.",
        "Ces bonbons sont parfaits pour une soirée cinéma !",
        "Pas fan des réglisses torsadées dans cet assortiment.",
        "J'adore le goût nostalgique de ces bonbons classiques.",
        "Ces bonbons sont trop fades et manquent de saveur.",
        "L'arôme fruité de ces bonbons est irrésistible.",
        "Je n'aime pas la texture croquante des bonbons durs.",
        "Le caramel dans ces bonbons est trop collant.",
        "Ces bonbons sont une explosion de bonheur dans ma bouche !",
        "Pas fan des saveurs de fruits artificiels.",
        "La saveur caramel au beurre salé est une révélation !",
        "Je n'aime pas la douceur excessive de certains bonbons.",
        "Ces bonbons sont une délicieuse friandise après un repas.",
        "Pas fan de la texture trop mâchée.",
        "La combinaison de sucré et acidulé est parfaite !",
        "Ces bonbons me ramènent aux souvenirs des vacances d'été.",
        "Trop de saveur de noix de coco dans ces bonbons.",
        "Ces bonbons sont parfaits pour partager avec des amis.",
        "Pas fan des bonbons durs qui prennent une éternité à fondre.",
        "J'adore le croustillant du sucre caramélisé dans ces friandises !",
        "Ces bonbons sont un peu trop collants à mon goût.",
        "L'acidité dans ces bonbons est juste parfaite !",
        "Pas fan de l'arrière-goût d'édulcorant artificiel.",
        "Ces bonbons sont parfaits pour une pause pendant le travail.",
        "Le revêtement chocolaté de ces bonbons est trop fin.",
        "Ces bonbons sont une explosion de joie à chaque bouchée !",
        "Pas fan du centre trop mou dans certains chocolats.",
        "Ces bonbons sont une véritable explosion de saveurs !",
        "Pas fan de la texture gélatineuse de certains bonbons.",
        "La finesse du chocolat dans ces bonbons est exquise !",
        "Je n'aime pas le goût de réglisse persistant dans ces bonbons.",
        "Ces bonbons sont trop sucrés pour mes papilles.",
        "Les bonbons à la menthe laissent une sensation rafraîchissante.",
        "La combinaison de fruits et de chocolat est divine !",
        "Les bonbons à la menthe sont toujours une agréable surprise.",
        "Les bonbons à la noix de coco ne sont pas à mon goût.",
        "Ces bonbons sont parfaits pour une pause sucrée.",
        "Je ne suis pas fan de la texture collante de certains bonbons.",
        "Le mélange de caramel et de noix est délicieux !",
        "Ces bonbons sont trop artificiels à mon goût.",
        "Les bonbons à mâcher restent une valeur sûre.",
        "J'adore la diversité de saveurs dans ce mélange de bonbons.",
        "Certains bonbons sont trop forts en épices pour moi.",
        "Le chocolat noir a une intensité de saveur que j'apprécie.",
        "Ces bonbons acidulés sont une explosion en bouche !",
        "La garniture de caramel est trop dégoulinante dans ces bonbons.",
        "Le mariage du chocolat et de la cacahuète est divin !",
        "Les colorants artificiels dans certains bonbons me dérangent.",
        "Les truffes au chocolat fondent délicieusement en bouche.",
        "Certains bonbons ont une texture trop sèche à mon goût.",
        "Les arômes fruités de ces bonbons sont un délice.",
        "Ces bonbons sont trop durs et blessent mes dents.",
        "Les bonbons aux noix sont une véritable gourmandise !",
        "La collanté de certains bonbons à mâcher me dérange.",
        "Ces bonbons sont ma petite indulgence secrète.",
        "Le sucré-salé de certains bonbons est un régal !",
        "Les bonbons ont un goût trop chimique pour moi.",
        "Les bonbons à la cerise sont un pur délice !",
        "Le revêtement des bonbons au chocolat est un peu trop fin.",
        "Une poignée de ces bonbons rend une soirée cinéma parfaite !",
        "Les réglisses torsadées ne sont pas à mon goût.",
        "La nostalgie des bonbons classiques est inégalée.",
        "Ces bonbons sont trop fades et manquent de saveur.",
        "L'odeur fruitée de ces bonbons est irrésistible.",
        "Je ne suis pas fan de la dureté des bonbons durs.",
        "Le caramel de ces bonbons est trop collant.",
        "Ces bonbons sont un rayon de soleil en bouche !",
        "Les saveurs de fruits artificiels ne me conviennent pas.",
        "La saveur caramel salé est un changement de jeu !",
        "La douceur excessive de certains bonbons me dérange.",
        "Ces bonbons sont un régal après un repas.",
        "La texture trop mâchée de certains bonbons ne me plaît pas.",
        "La combinaison de sucré et acidulé est parfaite !",
        "Ces bonbons me rappellent les souvenirs des vacances d'été.",
        "Il y a trop de noix de coco dans ces bonbons.",
        "Ces bonbons sont parfaits à partager entre amis.",
        "Les bonbons durs qui prennent une éternité à fondre ne sont pas pour moi.",
        "J'adore le croustillant du sucre caramélisé dans ces friandises !",
        "Ces bonbons sont un peu trop collants à mon goût.",
        "L'acidité de ces bonbons est tout simplement parfaite !",
        "L'arrière-goût d'édulcorant artificiel me dérange.",
        "Ces bonbons sont parfaits pour une pause pendant le travail.",
        "Le revêtement chocolaté de ces bonbons est trop fin.",
        "Ces bonbons sont une explosion de joie à chaque bouchée !",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Ces bonbons sont un délice à chaque bouchée !",
        "La texture fondante de ces chocolats est divine.",
        "Je ne suis pas fan des bonbons à la menthe.",
        "Les bonbons à la framboise sont une explosion de saveurs.",
        "Ces bonbons ont une douceur parfaite pour moi.",
        "La combinaison de caramel et de noisettes est délicieuse !",
        "Certains bonbons sont un peu trop forts en sucre.",
        "Les bonbons acidulés réveillent mes papilles.",
        "Le goût naturel des bonbons à la fraise est incroyable.",
        "Je ne suis pas fan des bonbons trop amers.",
        "Les bonbons fourrés au chocolat sont une surprise gourmande.",
        "Ces bonbons sont idéaux pour une pause sucrée au bureau.",
        "Les bonbons gélifiés ont une consistance agréable à mâcher.",
        "La diversité de saveurs dans cet assortiment est fantastique !",
        "Ces bonbons sont un réconfort après une journée difficile.",
        "Les bonbons à la violette sont une découverte exquise.",
        "La combinaison de caramel et de sel est une merveille.",
        "Les bonbons au miel sont une délicate sucrerie.",
        "Je ne suis pas fan des bonbons au réglisse noir.",
        "Les bonbons au café sont parfaits pour les amateurs de café.",
        "Ces bonbons sont un incontournable pour les fêtes.",
        "La subtilité des bonbons à la vanille est divine.",
        "Certains bonbons sont trop collants pour moi.",
        "Les bonbons au citron sont une explosion de fraîcheur.",
        "Ces bonbons me rappellent les douceurs de mon enfance.",
        "La richesse du chocolat dans ces bonbons est délicieuse.",
        "Je ne suis pas fan des bonbons à la réglisse salée.",
        "Les bonbons à la myrtille sont une expérience gustative unique.",
        "Ces bonbons sont une belle addition à un panier-cadeau.",
        "Les bonbons sans sucre sont une option plus saine.",
        "La texture croustillante de certains bonbons est agréable.",
        "Les bonbons à la poire ont une saveur délicate.",
        "Ces bonbons sont une gourmandise idéale en voyage.",
        "Les bonbons à la pêche sont une agréable surprise.",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Les bonbons à la noix de cajou sont une combinaison parfaite.",
        "Ces bonbons sont une explosion de saveurs tropicales.",
        "Je ne suis pas fan des bonbons au réglisse rouge.",
        "Les bonbons à la pomme sont un classique apprécié.",
        "Ces bonbons sont parfaits pour une soirée entre amis.",
        "La combinaison de chocolat blanc et de fruits rouges est délicieuse.",
        "Je ne suis pas fan des bonbons trop acides.",
        "Les bonbons à la noix de muscade ont une saveur chaleureuse.",
        "Ces bonbons sont une délicieuse alternative aux chocolats traditionnels.",
        "La douceur des bonbons au lait est inégalée.",
        "Les bonbons au caramel salé sont une véritable indulgence.",
        "Ces bonbons sont parfaits pour une soirée de détente.",
        "La texture moelleuse de certains bonbons est agréable à savourer.",
        "Les bonbons à la cerise noire sont une découverte délicieuse.",
        "Ces bonbons sont une excellente option pour les amateurs de chocolat noir.",
        "La fraîcheur des bonbons à la menthe poivrée est revigorante.",
        "Je ne suis pas fan des bonbons au café au goût fort.",
        "Les bonbons à la mangue ont une saveur tropicale exotique.",
        "Ces bonbons sont un plaisir sucré pendant les jours gris.",
        "La combinaison de chocolat au lait et de noisettes est exquise.",
        "Les bonbons au citron vert ont une acidité rafraîchissante.",
        "Ces bonbons sont une belle surprise dans chaque paquet.",
        "Les bonbons à la noix de coco sont une escapade tropicale.",
        "Je ne suis pas fan des bonbons au goût artificiel.",
        "Les bonbons à la framboise bleue sont une trouvaille délicieuse.",
        "Ces bonbons sont parfaits pour une soirée romantique.",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Les bonbons à la pistache ont une saveur unique et délicieuse.",
        "Ces bonbons sont un délice sucré pour les moments spéciaux.",
        "La douceur des bonbons au miel est apaisante.",
        "Je ne suis pas fan des bonbons au chocolat blanc.",
        "Les bonbons à l'orange sont une explosion de saveurs agrumes.",
        "Ces bonbons sont parfaits pour une journée en plein air.",
        "Les bonbons à la noisette ont une richesse de saveur.",
        "La combinaison de caramel et de chocolat noir est un régal.",
        "Ces bonbons sont une gourmandise parfaite pour les amateurs de caramel.",
        "Les bonbons à la cannelle ont une saveur épicée réconfortante.",
        "Ces bonbons sont une douceur bienvenue pendant les moments stressants.",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Les bonbons à la menthe-chocolat sont une combinaison divine.",
        "Ces bonbons sont parfaits pour une soirée de jeux entre amis.",
        "La douceur des bonbons au lait condensé est irrésistible.",
        "Je ne suis pas fan des bonbons au pamplemousse trop acides.",
        "Les bonbons à la noix de coco râpée sont un délice tropical.",
        "Ces bonbons sont une excellente idée de cadeau gourmand.",
        "La variété dans cet assortiment de bonbons est impressionnante !",
        "Les bonbons à la pêche blanche ont une saveur délicate.",
        "Ces bonbons sont parfaits pour une soirée cinéma en famille.",
            "La texture crémeuse de certains bonbons est un plaisir indulgent.",
            "Les bonbons à la cerise acidulée sont une expérience gustative unique.",
            "Ces bonbons sont un régal sucré après un repas léger.",
            "Les bonbons à la mangue verte sont une découverte tropicale.",
            "La combinaison de chocolat et de caramel est toujours un succès.",
            "Ces bonbons sont une délicieuse façon de clôturer la journée.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la fraise des bois sont une friandise délicate.",
            "Ces bonbons sont un complément parfait à un café relaxant.",
            "La douceur des bonbons à la vanille est inégalée.",
            "Je ne suis pas fan des bonbons à la menthe poivrée trop forts.",
            "Les bonbons à la poire mûre sont une explosion de saveurs fruitées.",
            "Ces bonbons sont parfaits pour égayer une journée grise.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la noix de macadamia sont un pur délice.",
            "Ces bonbons sont une excellente option pour les amateurs de noix.",
            "La combinaison de chocolat blanc et de framboise est divine.",
            "Les bonbons à la fraise des champs ont une saveur authentique.",
            "Ces bonbons sont une excellente alternative aux chocolats traditionnels.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la mûre ont une saveur sucrée et acidulée.",
            "Ces bonbons sont parfaits pour un pique-nique en plein air.",
            "La texture fondante de certains bonbons est un véritable plaisir.",
            "Les bonbons à la groseille rouge sont une explosion de saveurs.",
            "Ces bonbons sont une gourmandise idéale pour les amateurs de fruits.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la noix de pécan sont un régal pour les papilles.",
            "Ces bonbons sont une excellente option pour les amateurs de fruits à coque.",
            "La combinaison de chocolat et de caramel salé est irrésistible.",
            "Les bonbons à la myrtille sauvage sont un délice de la nature.",
            "Ces bonbons sont parfaits pour une soirée détendue à la maison.",
            "La douceur des bonbons à la crème brûlée est exquise.",
            "Les bonbons à la framboise noire sont une découverte gustative.",
            "Ces bonbons sont une explosion de saveurs à chaque dégustation.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la pistache sont une délicatesse à savourer.",
            "Ces bonbons sont une excellente option pour les amateurs de fruits secs.",
            "La combinaison de chocolat blanc et de noix de coco est un délice tropical.",
            "Les bonbons à l'orange sanguine ont une saveur audacieuse.",
            "Ces bonbons sont parfaits pour une journée ensoleillée.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la banane ont une saveur douce et crémeuse.",
            "Ces bonbons sont un régal sucré pour les moments spéciaux.",
            "La douceur des bonbons à la praline est irrésistible.",
            "Je ne suis pas fan des bonbons au goût artificiel de melon.",
            "Les bonbons à la mangue mûre sont une escapade tropicale.",
            "Ces bonbons sont une excellente option pour les amateurs de fruits exotiques.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la fraise blanche sont une délicatesse printanière.",
            "Ces bonbons sont parfaits pour une soirée romantique.",
            "La texture fondante de certains bonbons est un véritable délice.",
            "Les bonbons à la violette sont une expérience gustative unique.",
            "Ces bonbons sont une gourmandise parfaite pour les amateurs de saveurs florales.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la mandarine ont une saveur fruitée et pétillante.",
            "Ces bonbons sont un complément parfait à un après-midi ensoleillé.",
            "La douceur des bonbons au chocolat au lait est inégalée.",
            "Les bonbons à la noix de coco et au chocolat noir sont un délice exquis.",
            "Ces bonbons sont parfaits pour une soirée de détente après le travail.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la pomme verte ont une saveur acidulée et rafraîchissante.",
            "Ces bonbons sont une explosion de saveurs fruitées en bouche.",
            "La combinaison de chocolat blanc et de canneberge est divine.",
            "Les bonbons à la menthe fraîche sont un plaisir revigorant.",
            "Ces bonbons sont parfaits pour une pause gourmande en plein air.",
            "La douceur des bonbons à la crème glacée à la vanille est un pur délice.",
            "Les bonbons au melon d'eau ont une saveur estivale désaltérante.",
            "Ces bonbons sont une excellente option pour les chaudes journées d'été.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la framboise et au chocolat blanc sont une combinaison délicieuse.",
            "Ces bonbons sont un régal sucré pour les amateurs de saveurs fruitées.",
            "La combinaison de chocolat et de fruits rouges est irrésistible.",
            "Les bonbons à la pastèque ont une saveur juteuse et sucrée.",
            "Ces bonbons sont parfaits pour une journée ensoleillée au parc.",
            "La variété dans cet assortiment de bonbons est impressionnante !",
            "Les bonbons à la menthe glaciale sont un rafraîchissement intense.",
            "Ces bonbons sont un complément parfait à une soirée d'hiver"
    };

    private static readonly string[] Names =
    {
        "Citrouille Piquante",
        "Yeux de Sorcière",
        "Chauve-Souris Croquantes",
        "Bonbons Maudits",
        "Chocolat Noir de Minuit",
        "Dentelle de Fantôme",
        "Os Sucrés",
        "Serpent Acidulé",
        "Doigts de Zombie",
        "Cerveau Gélifié",
        "Potion de Sorcière Sucrée",
        "Araignée au Chocolat",
        "Nuit Noire Fondante",
        "Cimetière Croustillant",
        "Orbes Enchantées",
        "Verrues Caramel",
        "Griffe de Loup-Garou",
        "Fioles de Magie Sucrée",
        "Bonbons Hurlants",
        "Chaudron Magique Fondant",
        "Gâteau de la Lune Maudite",
        "Crâne en Sucre",
        "Tarentule Tranchante",
        "Dracula Délicieux",
        "Potion de Lueur Verte",
        "Esprit d'Orange Sanguine",
        "Griffes de Vampire",
        "Délice de la Crypte",
        "Boule de Feu Sorcière",
        "Bonbons Cauchemardesques",
        "Toile d'Araignée Sucrée",
        "Éclats de Lune Noire",
        "Âmes Confites",
        "Dent de Loup-Garou",
        "Biscuits Fantômes",
        "Corne de Licorne Fondante",
        "Feu Follet Fruité",
        "Cerveau Zombie Croustillant",
        "Balai de Sorcière en Sucre",
        "Larmes de Banshee",
        "Truffes d'Esprit",
        "Os de Dragon Sucré",
        "Brouillard de Chocolat",
        "Étoiles Filantes à Croquer",
        "Sucettes Mysterieuses",
        "Cris de Chauve-Souris"
    };
    
    public static readonly string[] Images =
    {
        "Candy 1.png",
        "Candy 9.png",
        "Winged Lollipop 4.png",
        "Candy 4.png",
        "Candy 14.png",
        "Winged Lollipop 9.png",
        "Candy 15.png",
        "Drippy Ghost 8.png",
        "Bone.png",
        "Drippy Ghost 11.png",
        "Drippy Ghost 2.png",
        "Candy 6.png",
        "Drippy Ghost 12.png",
        "Candy 11.png",
        "Drippy Ghost 9.png",
        "Candy 17.png",
        "Winged Lollipop 7.png",
        "Winged Lollipop 11.png",
        "Candy Corn 1.png",
        "Candy 12.png",
        "Drippy Ghost 5.png",
        "Drippy Ghost 1.png",
        "Candy 2.png",
        "Candy 10.png",
        "Candy 5.png",
        "Winged Lollipop 8.png",
        "Winged Lollipop 6.png",
        "Candy 3.png",
        "Candy Corn 2.png",
        "Candy Carrot.png",
        "Drippy Ghost 7.png",
        "Drippy Ghost 4.png",
        "Winged Lollipop 1.png",
        "Candy 13.png",
        "Winged Lollipop 12.png",
        "Drippy Ghost 3.png",
        "Bone Apple.png",
        "Winged Lollipop 5.png",
        "Candy 8.png",
        "Candy 16.png",
        "Winged Lollipop 2.png",
        "Drippy Ghost 10.png",
        "Winged Lollipop 10.png",
        "Candy 7.png",
        "Drippy Ghost 6.png",
        "Winged Lollipop 3.png"
    };

}