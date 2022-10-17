using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlasmanShovels.Data;
using System;
using System.Linq;

namespace PlasmanShovels.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlasmanShovelsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlasmanShovelsContext>>()))
            {
                // Look for any movies.
                if (context.Shovel.Any())
                {
                    return;   // DB has been seeded
                }

                context.Shovel.AddRange(
                    new Shovel
                    {
                        Company = "plasman",
                        Usage = "snow",
                        Material = "plastic",
                        Price = 11.99M,
                        Type = "premium",
                        Weight = "0.758kg",
                        Rating = "Excellent"
                    },
                     new Shovel
                     {
                         Company = "plasman",
                         Usage = "soil",
                         Material = "wood",
                         Price = 7.99M,
                         Type = "cheap",
                         Weight = "1kg",
                         Rating = "Very Good"
                     },
                      new Shovel
                    {
                        Company = "plasman",
                        Usage = "cement",
                        Material = "wood",
                        Price = 7.99M,
                        Type = "average",
                        Weight = "0.900kg",
                          Rating = "Good"
                      },
                        new Shovel
                        {
                            Company = "plasman",
                            Usage = "coal",
                            Material = "iron",
                            Price = 15.99M,
                            Type = "premium",
                            Weight = "1.3kg",
                            Rating = "Good"
                        },
                          new Shovel
                          {
                              Company = "plasman",
                              Usage = "soil",
                              Material = "wood",
                              Price = 5.99M,
                              Type = "cheap",
                              Weight = "0.829kg",
                              Rating = "Very Poor"
                          },
                            new Shovel
                            {
                                Company = "plasman",
                                Usage = "ice",
                                Material = "iron",
                                Price = 14.99M,
                                Type = "premium",
                                Weight = "1.1kg",
                                Rating = "Good"
                            },
                              new Shovel
                              {
                                  Company = "plasman",
                                  Usage = "coal",
                                  Material = "wood",
                                  Price = 8.99M,
                                  Type = "cheap",
                                  Weight = "1.05kg",
                                  Rating = "Very Good"
                              },
                                new Shovel
                                {
                                    Company = "plasman",
                                    Usage = "snow",
                                    Material = "pvc",
                                    Price = 16.99M,
                                    Type = "premium",
                                    Weight = "0.9kg",
                                    Rating = "Poor"
                                },
                                  new Shovel
                                  {
                                      Company = "plasman",
                                      Usage = "soil",
                                      Material = "wood,iron",
                                      Price = 13.99M,
                                      Type = "premium",
                                      Weight = "0.857kg",
                                      Rating = "Very Poor"
                                  },
                                    new Shovel
                                    {
                                        Company = "plasman",
                                        Usage = "gravel",
                                        Material = "iron",
                                        Price = 14.99M,
                                        Type = "premium",
                                        Weight = "1.5kg",
                                        Rating = "Excellent"
                                    }


                );
                context.SaveChanges();
            }
        }
    }
}