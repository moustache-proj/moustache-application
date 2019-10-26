using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using MoustacheApp.Models;

namespace MoustacheApp.Data
{
    public static class SeedQuizData
    {
        public static async Task CreateDemoQuiz(ApplicationDbContext context)
        {
            // Look for demo quiz
            var quizSeed = context.MoQuizDetail.Where(q => q.Name == "James Bond Trivia Quiz").SingleOrDefault();
            if (quizSeed != null)
            {
                return;     // DB has been seeded
            }

            // add demo quiz
            var quiz = new MoQuizDetail
            {
                Current = 1,
                CommonId = Guid.NewGuid().ToString(),
                Name = "James Bond Trivia Quiz",
                Information = "As Daniel Craig once again prepares to don the tuxedo as James Bond, " +
                                "test your knowledge of 007's old and new and discover if you're " +
                                "licensed to kill...or not.",
                Published = 1,
                Attempts = 0,
                MoQuestion = new List<MoQuestion>
                {
                    new MoQuestion { Question = "In which film did James Bond first drive his now-iconic Aston Martin?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Dr. No" },
                                        new MoAnswer { Answer = "Thunderball" },
                                        new MoAnswer { Answer = "License to Kill" },
                                        new MoAnswer { Answer = "Goldfinger", Correct = 1 }
                                    }
                    },
                    new MoQuestion { Question = "Who was the first actor to play James Bond?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "David Niven" },
                                        new MoAnswer { Answer = "Barry Nelson", Correct = 1 },
                                        new MoAnswer { Answer = "Sean Connery" },
                                        new MoAnswer { Answer = "Roger Moore" }
                                    }
                    },
                    new MoQuestion { Question = "Which film is a remake of ‘Thunderball’?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Never Say Never Again", Correct = 1 },
                                        new MoAnswer { Answer = "Octopussy" },
                                        new MoAnswer { Answer = "Goldfinger" },
                                        new MoAnswer { Answer = "Tomorrow Never Dies" }
                                    }
                    },
                    new MoQuestion { Question = "The screenplay for which Bond film was written by " +
                                                "‘Charlie and the Chocolate Factory’ author Roald Dahl?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "The World is Not Enough" },
                                        new MoAnswer { Answer = "GoldenEye" },
                                        new MoAnswer { Answer = "Dr. No" },
                                        new MoAnswer { Answer = "You Only Live Twice", Correct = 1 }
                                    }
                    },
                    new MoQuestion { Question = "What is M’s real name?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Matthew" },
                                        new MoAnswer { Answer = "Myron" },
                                        new MoAnswer { Answer = "Miles", Correct = 1 },
                                        new MoAnswer { Answer = "Michael" }
                                    }
                    },
                    new MoQuestion { Question = "Which of these Bond films was based on a short story?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Skyfall" },
                                        new MoAnswer { Answer = "Casino Royale" },
                                        new MoAnswer { Answer = "For Your Eyes Only", Correct = 1 },
                                        new MoAnswer { Answer = "Octopussy" }
                                    }
                    },
                    new MoQuestion { Question = "What is the inspiration for the name of the film ‘GoldenEye’?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "It's the name of Fleming's yacht." },
                                        new MoAnswer { Answer = "It's the house where Fleming wrote the Bond novels.", Correct = 1 },
                                        new MoAnswer { Answer = "It's the name of Fleming's dog." },
                                        new MoAnswer { Answer = "It's the name of Fleming's second novel." }
                                    }
                    },
                    new MoQuestion { Question = "Which Bond film is the first to feature a woman as the main villain?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Moonraker" },
                                        new MoAnswer { Answer = "The World is Not Enough", Correct = 1 },
                                        new MoAnswer { Answer = "Die Another Day" },
                                        new MoAnswer { Answer = "Quantum of Solace" }
                                    }
                    },
                    new MoQuestion { Question = "Where does the character James Bond get his name?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Fleming's commanding officer." },
                                        new MoAnswer { Answer = "The editor of the 'New York Times'." },
                                        new MoAnswer { Answer = "The author of 'Birds of the West Indies'.", Correct = 1 },
                                        new MoAnswer { Answer = "Fleming's next door neighbor." }
                                    }
                    },
                    new MoQuestion { Question = "Which is the only Bond film where James Bond does not drive a car?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "You Only Live Twice", Correct = 1 },
                                        new MoAnswer { Answer = "From Russia With Love" },
                                        new MoAnswer { Answer = "Goldfinger" },
                                        new MoAnswer { Answer = "Live and Let Die" }
                                    }
                    },
                    new MoQuestion { Question = "How many BMW 750's were destroyed during the making of ‘Tomorrow Never Dies’?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "11" },
                                        new MoAnswer { Answer = "30" },
                                        new MoAnswer { Answer = "25" },
                                        new MoAnswer { Answer = "15", Correct = 1 }
                                    }
                    },
                    new MoQuestion { Question = "How does Vesper die in the ‘Casino Royale’ novel?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Sleeping pill overdose", Correct = 1 },
                                        new MoAnswer { Answer = "Drowns" },
                                        new MoAnswer { Answer = "Gunshot to the head" },
                                        new MoAnswer { Answer = "Jumps off a building" },
                                        new MoAnswer { Answer = "Steps into traffic" }
                                    }
                    },
                    new MoQuestion { Question = "Which actor wore a hairpiece during his time portraying James Bond?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Roger Moore" },
                                        new MoAnswer { Answer = "Sean Connery", Correct = 1 },
                                        new MoAnswer { Answer = "Timothy Dalton" },
                                        new MoAnswer { Answer = "Pierce Brosnan" }
                                    }
                    },
                    new MoQuestion { Question = "Which Bond movie has the longest run time?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Dr. No" },
                                        new MoAnswer { Answer = "Die Another Day" },
                                        new MoAnswer { Answer = "Spectre", Correct = 1  },
                                        new MoAnswer { Answer = "Moonraker" }
                                    }
                    },
                    new MoQuestion { Question = "Who performed the theme song for ‘Live and Let Die’?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "The Rolling Stones" },
                                        new MoAnswer { Answer = "Paul McCartney and Wings", Correct = 1 },
                                        new MoAnswer { Answer = "The Supremes" },
                                        new MoAnswer { Answer = "The Doors" }
                                    }
                    },
                    new MoQuestion { Question = "What was the original title to ‘Licence to Kill’?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Kill Order" },
                                        new MoAnswer { Answer = "Licence to Murder" },
                                        new MoAnswer { Answer = "Licence Revoked", Correct = 1 },
                                        new MoAnswer { Answer = "Murder Report" }
                                    }
                    },
                    new MoQuestion { Question = "What is the name of the organization that is Bond’s major nemesis?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "HYDRA" },
                                        new MoAnswer { Answer = "PRISM" },
                                        new MoAnswer { Answer = "SATO" },
                                        new MoAnswer { Answer = "SPECTRE", Correct = 1 }
                                    }
                    },
                    new MoQuestion { Question = "Which of these is the name of a henchman in the Bond films?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Mr. Wint", Correct = 1 },
                                        new MoAnswer { Answer = "Nobbins" },
                                        new MoAnswer { Answer = "Shins" },
                                        new MoAnswer { Answer = "Hat Trick" }
                                    }
                    },
                    new MoQuestion { Question = "What is the motto on the Bond family crest?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Live and let die" },
                                        new MoAnswer { Answer = "The world is not enough", Correct = 1 },
                                        new MoAnswer { Answer = "You only live twice" },
                                        new MoAnswer { Answer = "Die another day" }
                                    }
                    },
                    new MoQuestion { Question = "What does SPECTRE mean?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Secret Enlistment of Chaotic Terror Routine Execution" },
                                        new MoAnswer { Answer = "Southern English Chess Trainers Riding Escalators" },
                                        new MoAnswer { Answer = "Special Executive for Counterintelligence Terrorism Revenge and Extortion", Correct = 1 },
                                        new MoAnswer { Answer = "Nothing. Just SPECTRE." }
                                    }
                    },
                    new MoQuestion { Question = "What branch of the military did James Bond serve in?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Royal Air Force" },
                                        new MoAnswer { Answer = "Royal Navy", Correct = 1 },
                                        new MoAnswer { Answer = "Armed Forces" },
                                        new MoAnswer { Answer = "Royal Marines" }
                                    }
                    },
                    new MoQuestion { Question = "What is the name of the official production company for the James Bond films?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Bonded Films" },
                                        new MoAnswer { Answer = "Eon Productions", Correct = 1 },
                                        new MoAnswer { Answer = "Ionic Pictures" },
                                        new MoAnswer { Answer = "Q Productions" }
                                    }
                    },
                    new MoQuestion { Question = "Who is the youngest actor to play James Bond?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Timothy Dalton" },
                                        new MoAnswer { Answer = "Daniel Craig" },
                                        new MoAnswer { Answer = "Mick Jagger" },
                                        new MoAnswer { Answer = "George Lazenby", Correct = 1 }
                                    }
                    },
                    new MoQuestion { Question = "What is the name of James Bond’s wife?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Christmas Jones" },
                                        new MoAnswer { Answer = "Pussy Galore" },
                                        new MoAnswer { Answer = "Tracy Draco", Correct = 1 },
                                        new MoAnswer { Answer = "Jane Smyth" }
                                    }
                    },
                    new MoQuestion { Question = "Which Bond film made the least money?",
                                    MoAnswer = new List<MoAnswer>
                                    {
                                        new MoAnswer { Answer = "Live and Let Die" },
                                        new MoAnswer { Answer = "Licence to Kill", Correct = 1 },
                                        new MoAnswer { Answer = "Skyfall" },
                                        new MoAnswer { Answer = "Goldfinger" }
                                    }
                    }
                }
            };
            context.Add(quiz);
            context.SaveChanges();
        }
    }
}
