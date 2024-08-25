using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.Control
{
    // CustomBorder hérite de la classe Border, permettant une personnalisation de la bordure
    public class CustomBorder : Border
    {
        // Constructeur de la classe CustomBorder
        public CustomBorder()
        {
            // Définit une translation aléatoire sur l'axe X, entre -500 et 500
            TranslationX = new Random().Next(-500, 500);

            // Définit la rotation en fonction de TranslationX, avec un minimum de 100 degrés
            Rotation = Math.Max(TranslationX, 100);

            // Applique un rayon de coin aléatoire à la bordure
            AddCornerRadius();

            // Abonne un événement pour l'animation lors du chargement complet de l'élément
            Loaded += (s, e) =>
            {
                // Anime la translation pour ramener l'élément à la position X = 0 sur 1000 ms
                this.TranslateTo(0, 0, 1000, Easing.CubicInOut);

                // Anime la rotation pour ramener l'élément à 0 degrés sur 1000 ms
                this.RotateTo(0, 1000, Easing.CubicOut);
            };
        }

        // Liste des valeurs possibles pour le rayon des coins
        private List<int> CornerValues = new List<int> { 10, 40, 70, 100 };

        // Méthode pour ajouter un rayon de coin à la bordure
        private void AddCornerRadius()
        {
            // Sélectionne un index aléatoire pour choisir un rayon de coin
            var index = new Random().Next(CornerValues.Count);

            // Applique le rayon de coin sélectionné à la bordure en utilisant un RoundRectangle
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[index]),
            };
        }
    }
}
