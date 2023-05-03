using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Attempt_1.Data;
using System;
using System.Linq;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.Collections.Generic;
using System.Drawing.Drawing2D;


namespace Attempt_1.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider) 
		{ 
		using(var context = new WineZContext(
			serviceProvider.GetRequiredService<DbContextOptions<WineZContext>>()))
			{
				if(context.Wines.Any())
				{
					return; // DB has been seeded
				}
				context.Wines.AddRange(
					new Wine
					{
						WineName = "Chateau Margaux",
						Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fwine-bottle&psig=AOvVaw088Z7qjImznJ4mOiY1vUrf&ust=1682981223851000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCJjA8OTX0v4CFQAAAAAdAAAAABAE",
						Price = 50M,
						Blurb = "A classic Bordeaux blend of Cabernet Sauvignon, Merlot, Cabernet Franc, and Petit Verdot. With its velvety texture, complex aromas of blackcurrant, tobacco, and leather, and long, elegant finish, this wine is a true masterpiece.",
						Quantity= 75,
						Type = "Red wine",
						Category="Cabernet Sauvignon blend" 
					},
					new Wine
					{
						WineName= "Opus One",
						Image= "",
						Price= 35M,
						Blurb= "A collaboration between Robert Mondavi and Baron Philippe de Rothschild, this Bordeaux-style blend is a true gem. It boasts a deep, rich color, aromas of blackberry, cassis, and chocolate, and a full-bodied, velvety texture that lingers on the palate.",
						Quantity = 750,
						Type= "Red wine",
						Category= " Cabernet Sauvignon blend"
					},
					new Wine
					{
						WineName = "Cloudy Bay Sauvignon Blanc",
						Image = "",
						Price = 30M,
						Blurb = "With its vibrant aromas of grapefruit, lime, and passionfruit, this Sauvignon Blanc from New Zealand's Marlborough region is a refreshing and zesty wine that pairs perfectly with seafood or salads.",
						Quantity = 750,
						Type = "White wine",
						Category = " Sauvignon Blanc"

					},
					new Wine
					{
						WineName = "Domaine de la Romanee-Conti Grand Cru",
						Image = "",
						Price = 50M,
						Blurb = "Considered by many to be the world's greatest wine, this Pinot Noir from Burgundy's Romanee-Conti vineyard is a rare and precious gem. With its exquisite aromas of cherry, raspberry, and forest floor, and its silky, nuanced texture, it is a wine that will be cherished for years to come",
						Quantity = 12,
						Type = "Red wine",
						Category = "Pinot Noir"

					},
					new Wine
					{
						WineName = "Penfolds Grange",
						Image = "",
						Price = 85M,
						Blurb = "A flagship Shiraz blend from Australia's most iconic wine producer, this wine is rich, powerful, and complex, with aromas of blackberry, plum, and vanilla, and a long, silky finish. A true collector's item.",
						Quantity = 43,
						Type = "Red wine",
						Category = "Shiraz blend"

					},
					new Wine
					{
						WineName = "Bollinger Special Cuvée Brut Champagne",
						Image = "",
						Price = 70M,
						Blurb = "One of the world's most famous Champagnes, this blend of Pinot Noir, Chardonnay, and Pinot Meunier is rich and complex, with notes of brioche, apple, and pear. It is perfect for celebrating special occasions or just enjoying with friends.",
						Quantity =75,
						Type = "Sparkling wine",
						Category ="Champagne"

					},
					new Wine
					{
						WineName = "Catena Zapata Nicolas Malbec",
						Image = "",
						Price = 120M,
						Blurb = "From one of Argentina's most prestigious wineries, this Malbec is a rich, full-bodied wine with aromas of blackberry, plum, and chocolate, and a long, elegant finish. It pairs perfectly with grilled meats or hearty stews.",
						Quantity = 23,
						Type = "Red wine",
						Category = "Merlot"

					},
					new Wine
					{
						WineName = "Château d'Yquem",
						Image = "",
						Price = 120M,
						Blurb = "A renowned sweet wine from the Sauternes region of Bordeaux, France. With its honeyed flavors, notes of apricot and pineapple, and a luscious, silky texture, this wine is a perfect pairing for dessert or foie gras.",
						Quantity = 90,
						Type = "White wine",
						Category = "Sweet wine"

					},
					new Wine
					{
						WineName = "Krug Grand Cuvée Brut Champagne",
						Image = "",
						Price = 250M,
						Blurb = "A luxurious Champagne from the prestigious Krug house, made from a blend of over 120 wines. With its complex flavors of apple, honey, and nuts, and a creamy, elegant texture, this Champagne is a true indulgence.",
						Quantity = 24,
						Type = "Sparkling wine",
						Category = "Champagne"

					},
					new Wine
					{
						WineName = "Graham's 20-Year-Old Tawny Port",
						Image = "",
						Price = 60M,
						Blurb = "A beautifully aged Tawny Port from one of the most renowned Port houses in Portugal. With its rich, nutty flavors, notes of caramel and dried fruit, and a long, smooth finish, this wine is perfect for sipping after dinner or paired with cheese and nuts.",
						Quantity = 33,
						Type = "Fortified wine",
						Category = "Port"

					}
					);
				context.SaveChanges();
			}
		}
	}
}
