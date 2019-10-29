using Microsoft.EntityFrameworkCore.Migrations;

namespace MedievalPlantGuild.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "CommonName", "Habitat", "Identification", "LatinName", "Poisonous", "Uses" },
                values: new object[,]
                {
                    { 1, "American Ginseng", "American Ginseng can be found in much of the eastern and central United States and in part of southeastern Canada. It is found primarily in deciduous forests of the Appalachian and Ozark regions of the United States. American ginseng is found in full shade environments in these deciduous forests underneath hardwoods. Due to this very specialized growing environment and its demand in the commercial market it has started to reach an endangered status in some areas. It can be found throughout eastern Canada and the northeastern United States.", "The aromatic root of American ginseng (Panax quinquefolius) resembles a small parsnip that forks as it matures. The plant grows 6 inches to 18 inches tall, usually bearing three leaves, each with three to five leaflets, 2 inches to 5 inches long.", "Panax quinquefolius", true, "There is no evidence that American ginseng is effective against the common cold or how severe the infections are. There is tentative evidence that it may lessen the length of sickness when used preventively. Individuals requiring anticoagulant therapy such as warfarin should avoid use of ginseng. It is not recommended for individuals with impaired liver or renal function, or during pregnancy or breastfeeding. Other adverse effects include: headaches, anxiety, trouble sleeping and an upset stomach. Recent studies have shown that through the many cultivated procedures that American ginseng is grown, fungal molds, pesticides, and various metals and residues have contaminated the crop. Though these contaminating effects are not considerably substantial, they do pose health concerns that could lead to neurological problems, intoxication, cardiovascular disease and cancer." },
                    { 2, "Ginger", "From India, it was also carried by traders into the Middle East and the Mediterranean by around the 1st century CE. It was primarily grown in southern India and the Greater Sunda Islands during the spice trade, along with peppers, cloves, and numerous other spices.", " It is a herbaceous perennial which grows annual pseudostems (false stems made of the rolled bases of leaves) about a meter tall bearing narrow leaf blades. The inflorescences bear pale yellow with purple flowers and arise directly from the rhizome on separate shoots", "(Zingiber officinale", false, "Evidence that ginger helps alleviate nausea and vomiting resulting from chemotherapy or pregnancy is inconsistent.[2][28][29][30] There is no clear evidence of harm from taking ginger during pregnancy, although its safety has not been established.[28][31] Ginger is not effective for treating dysmenorrhea,[32] and there is insufficient evidence for it having analgesic properties due to the lack of well conducted trials. Available data provides weak evidence for its anti-inflammatory role and it may reduce the subjective experience of pain in osteoarthritis. Ginger is also used for various types of spices and teas" },
                    { 3, "Turmeric", "Native to the Indian subcontinent and Southeast Asia.", "Turmeric is a perennial herbaceous plant that reaches up to 1 m (3 ft 3 in) tall. Highly branched, yellow to orange, cylindrical, aromatic rhizomes are found.", "Curcuma longa", false, "Culinary, Dye, Indicator, Reduces Inflammation in the body, premote good digestion, premotes more energy. " },
                    { 4, "Burdock", "Native to Europe and Asia, several species have been widely introduced worldwide. Arctium species generally flower from July through to October. Burdock flowers provide essential pollen and nectar for honeybees around August when clover is on the wane and before the goldenrod starts to bloom.", "Arctium species generally flower from July through to October. Burdock flowers provide essential pollen and nectar for honeybees around August when clover is on the wane and before the goldenrod starts to bloom.Plants of the genus Arctium have dark green leaves that can grow up to 70 cm (28 in) long. They are generally large, coarse and ovate, with the lower ones being heart-shaped. They are woolly underneath. The leafstalks are generally hollow. The prickly heads of these plants (burrs) are noted for easily catching on to fur and clothing. In England, some birdwatchers have reported that birds have become entangled in the burrs leading to a slow death, as they are unable to free themselves. Burdock's clinging properties, in addition to thus providing an excellent mechanism for seed dispersal, led to the invention of the hook and loop fastener.", "Arctium", true, "Folk herbalists considered dried burdock to be a diuretic, diaphoretic, and a blood purifying agent. The seeds of A. lappa are used in traditional Chinese medicine under the name niubangzi (Chinese: 牛蒡子; pinyin: niúbángzi; some dictionaries list the Chinese as just Chinese: 牛蒡; pinyin: niúbàng). Burdock is a traditional medicinal herb used for many ailments. Burdock root oil extract, also called bur oil, is used in Europe as a scalp treatment. The green, above-ground portions may cause contact dermatitis in individual with allergies as the plant contains lactones." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 4);
        }
    }
}
