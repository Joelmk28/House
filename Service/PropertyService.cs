using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House.Model;

namespace House.Service
{
    public class PropertyService
    {
       public static List<Property> AllProperties => new List<Property>
        {
            new Property
            {
                DefaultImage = "https://images.prismic.io/travauxlib/0e9aa37c-8960-4ff0-8203-bd0a8bf3f068_prix-construction-maison-neuve.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&rect=0%2C0%2C1950%2C1200&w=1946&h=1198",
                Address = "123 Main St",
                Price = 250000,
                Images = new List<string> 
                { "https://static.cotemaison.fr/medias_11969/w_2048,h_1146,c_crop,x_0,y_51/w_2000,h_1125,c_fill,g_north/v1625148569/un-lieu-de-vacances-ou-les-sens-sont-en-eveil_6128360.jpg",
                    "https://images.prismic.io/travauxlib/4b644e16-4ddf-467c-8e00-9749667c2dcd_Maison%20re%CC%81nove%CC%81e.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&w=1000&h=667",
                    "https://static.cotemaison.fr/medias_11969/w_2048,h_1146,c_crop,x_0,y_51/w_2000,h_1125,c_fill,g_north/v1625148569/un-lieu-de-vacances-ou-les-sens-sont-en-eveil_6128360.jpg" }
            },
            new Property
            {
                DefaultImage = "https://images.prismic.io/travauxlib/4b644e16-4ddf-467c-8e00-9749667c2dcd_Maison%20re%CC%81nove%CC%81e.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&w=1000&h=667",
                Address = "456 Oak St",
                Price = 300000,
                Images = new List<string> { "https://static.cotemaison.fr/medias_11969/w_2048,h_1146,c_crop,x_0,y_51/w_2000,h_1125,c_fill,g_north/v1625148569/un-lieu-de-vacances-ou-les-sens-sont-en-eveil_6128360.jpg",
                    "https://www.createursdinterieur.com/static/431ac2dfe5de9c29e00b94aa49006fa9/670dc/cheminee-contemporaine.jpg" }
            },
            new Property
            {
                DefaultImage = "https://images.prismic.io/travauxlib/8bc49dfb-dbfe-4c1b-b40d-f34e683731cf_maison-architecte-en-bois.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&w=600&h=330",
                Address = "789 Pine St",
                Price = 275000M,
                Images = new List<string> { "https://images.prismic.io/travauxlib/0e9aa37c-8960-4ff0-8203-bd0a8bf3f068_prix-construction-maison-neuve.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&rect=0%2C0%2C1950%2C1200&w=1946&h=1198", 
                    "https://static.cotemaison.fr/medias_11969/w_2048,h_1146,c_crop,x_0,y_51/w_2000,h_1125,c_fill,g_north/v1625148569/un-lieu-de-vacances-ou-les-sens-sont-en-eveil_6128360.jpg", "image8.jpg" }
            },
            new Property
            {
                DefaultImage = "https://img.freepik.com/photos-gratuite/quartier-residentiel-moderne-toit-vert-balcon-genere-par-ia_188544-10276.jpg?size=626&ext=jpg",
                Address = "101 Maple St",
                Price = 350000M,
                Images = new List<string> { "https://www.lesmaisonsaura.com/wp-content/uploads/2016/03/illu-interieur-maison2-600x363.jpg",
                    "https://images.prismic.io/travauxlib/0e9aa37c-8960-4ff0-8203-bd0a8bf3f068_prix-construction-maison-neuve.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&rect=0%2C0%2C1950%2C1200&w=1946&h=1198" }
            },
            new Property
            {
                DefaultImage = "https://www.maisons-mca.com/wp-content/uploads/modele-maison-contemporaine.jpg",
                Address = "202 Birch St",
                Price = 400000,
                Images = new List<string> { "https://www.maisons-mca.com/wp-content/uploads/modele-maison-contemporaine-2.jpg",
                    "https://img.freepik.com/photos-gratuite/quartier-residentiel-moderne-toit-vert-balcon-genere-par-ia_188544-10276.jpg?size=626&ext=jpg", 
                    "https://www.createursdinterieur.com/static/431ac2dfe5de9c29e00b94aa49006fa9/670dc/cheminee-contemporaine.jpg" }
            },
            new Property
            {
                DefaultImage = "https://www.maisons-mca.com/wp-content/uploads/modele-maison-contemporaine-2.jpg",
                Address = "303 Cedar St",
                Price = 320000M,
                Images = new List<string> { "https://www.maisons-mca.com/wp-content/uploads/modele-maison-contemporaine.jpg", 
                    "https://www.createursdinterieur.com/static/9d7c6db9a95828bd6703bfdb3810971a/670dc/amenagement-interieur-maison-contemporaine.jpg",
                "https://images.prismic.io/travauxlib/4b644e16-4ddf-467c-8e00-9749667c2dcd_Maison%20re%CC%81nove%CC%81e.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&w=1000&h=667f"}
            },
            new Property
            {
                DefaultImage = "https://www.maisons-artis.com/media/cache/house_model_item/2024/05/5262-attik-arriere.jpg",
                Address = "404 Elm St",
                Price = 290000M,
                Images = new List<string> { "https://www.createursdinterieur.com/static/9d7c6db9a95828bd6703bfdb3810971a/670dc/amenagement-interieur-maison-contemporaine.jpg",
                    "https://www.loghouse.fi/wp-content/uploads/2024/07/Escalier-aito-maison-en-bois-Levi-laponie-finlande-542x780.jpg", "https://cache.marieclaire.fr/data/photo/w1536_ci/61/salon-bleu-er-blanc1.webp" }
            },
            new Property
            {
                DefaultImage = "https://static.cotemaison.fr/medias_11969/w_2048,h_1146,c_crop,x_0,y_51/w_2000,h_1125,c_fill,g_north/v1625148569/un-lieu-de-vacances-ou-les-sens-sont-en-eveil_6128360.jpg",
                Address = "505 Walnut St",
                Price = 360000,
                Images = new List<string> { "https://www.maisons-mca.com/wp-content/uploads/modele-maison-contemporaine.jpg",
                    "https://images.prismic.io/travauxlib/4b644e16-4ddf-467c-8e00-9749667c2dcd_Maison%20re%CC%81nove%CC%81e.jpg?ixlib=gatsbyFP&auto=compress%2Cformat&fit=clip&q=80&w=1000&h=667" }
            }
        };
    }
}
