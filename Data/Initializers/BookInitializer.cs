using ASP_site.Models;
using System.Collections.Generic;

namespace ASP_site.Data.Initializers
{
    public static class BookInitializer
    {
        public static (List<Book> books, List<Link> links) GetData()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Title = "A Bathroom of Her Own",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "This short story is political, like much of his non-fiction writing.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    }
                },
                new Book
                {
                    Title = "All You Zombies",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1959,
                    Type = BookType.ShortStory,
                    Description = "Made into the movie 'Predestination' by the Spierig Brothers in 2014 starring Ethan Hawke, Sarah Snook, and Noah Taylor.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "-And He Built a Crooked House-",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "An architect builds a tesserect house in the 4th dimension. First published in Astounding Science Fiction in February, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Between Planets",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Beyond Doubt",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe with Elma Wentz",
                    PublicationYear = 1941,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "A politician leverages the power of the gods to get elected. Originally published in Astonishing Stories in April, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Beyond This Horizon",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1948,
                    Type = BookType.Novel,
                    Description = "2018 Hugo Award (Retro Hugos: Novel): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    }
                },
                new Book
                {
                    Title = "The Black Pits of Luna",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Blowups Happen",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "Heinlein anticipates the hazards of nuclear power in this short story first appearing in the September 1940 issue of Astounding. Revised in 1946. Nominated for the 2016 Retro Hugo Award for Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "The Bulletin Board",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "Was one of Heinlein's short stories in Calling All Girls magazine, first published in 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "By His Bootstraps",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1941,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Time Gate. A man helps himself complete his thesis and complete a causal loop. First published in Astounding Science Fiction in October, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Cat Who Walks Through Walls",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "1986 Locus Award (SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "Citizen of the Galaxy",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "2022 Prometheus Award (Hall of Fame): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "Cliff and the Calories",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "One of Heinlein's few stories for girls, set in then modern times, first published in Calling All Girls magazine in 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Columbus Was a Dope",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Common Sense",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "In this sequel to 'Universe', Hugh Hoyland tries to restart the giant ship he lives on. First published in Astounding Science Fiction in October, 1941, then as one half of Orphans in the Sky in 1963.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Orphans of the Sky" }
                    }
                },
                new Book
                {
                    Title = "Coventry",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "Future psycholgists can cure violent behavior in this sequel to 'If This Goes On-' first published in the July 1940 issue of Astounding. Hubbard cited this as an influence on his writing of Dianetics. Nominated for the 2016 Retro Hugo Award for Novella, won the 2017 Prometheus Hall of Fame Award.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "Delilah and the Space Rigger",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Destination Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "Heinlein contributed to the screenplay of the 1950 movie Destination Moon, which was then adapted for radio.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "The Door into Summer",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "Adapted into a Japanese movie in 2021.",            
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "Double Star",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Description = "1956 Hugo Award (Novel): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "Elsewhen",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Caleb Saunders",
                    PublicationYear = 1941,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Elsewhere. A Professor shows his students how to travel to alternate worlds. First published in Astounding Science Fiction in September, 1941, and then as part of the 1953 collection 'Assignment in Eternity'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Farmer in the Sky",    
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.Novel,
                    Description = "Won the 2001 Retro Hugo for best novel. Initially serialized in a condensed version in Boys' Life magazine as Satellite Scout",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "Farnham's Freehold",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1964,
                    Type = BookType.Novel
                },
                new Book
                {
                    Title = "Field Defects: Memo from a Cyborg",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1975,
                    Type = BookType.ShortStory,
                    Description = "Written in 1975, published in 2010 in the Virginia Collection and then in May 2015 Galaxy magazine.",
                },
                new Book
                {
                    Title = "For Us, the Living: A Comedy of Customs",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2003,
                    Type = BookType.Novel,
                    Description = "Heinlein's first novel, written in 1938, but wasn't published until 2003.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Posthumous" }
                    }
                },
                new Book
                {
                    Title = "Free Men",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "Published in 1966, 2023 Prometheus Award (Hall of Fame Award): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book 
                {
                    Title = "Friday",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1982,
                    Type = BookType.Novel,
                    Description = "1983 Locus Award (SF Novel): Nominated, 1983 Hugo Award (Novel): Nominated, 1983 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Gentlemen, Be Seated!",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Glory Road",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1964,
                    Type = BookType.Novel,
                    Description = "1964 Hugo Award (Novel): Nominated, 1987 Locus Award (All-Time Best SF Novel): Nominated"
                },
                new Book
                {
                    Title = "Goldfish Bowl",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1942,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "Two men are trapped by an alien at the bottom of the ocean. 2018 Hugo Award (Retro Hugos: Novelette): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {   
                    Title = "The Green Hills of Earth",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "1952 Analog Award (All-Time Best Book): 8th Place",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" },
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    }
                },
                new Book
                {
                    Title = "Grumbles from the Grave",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "Posthumous Autobiography, 1990 Locus Award (Non-Fiction): Won, 1990 Hugo Award (Best Related Work): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Posthumous" }
                    }
                },
                new Book
                {
                    Title = "Gulf",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "A group of adept humans battle in secret in high stakes espionage.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Happy Days Ahead",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Have Space Suit—Will Travel",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "1959 Hugo Award (Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "How to be a Survivor",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "I Will Fear No Evil",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1970,
                    Type = BookType.Novel,
                    Description = "1971 Locus Award (Novel): Nominated, 1978 Seiun Award (Translated Long Work): Won"
                },
                new Book
                {
                    Title = "If This Goes On—",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First novel length work first published in the February and March 1940 issues of Astounding. Heinlein depicts a revolution in the future where the US has become an authoritarian theocracy. Won the 2016 Retro Hugo Award for Novella.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "Inside Intourist",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "It's Great to Be Back!",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Jerry Was a Man",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "A geneticially modified chimpanzee fights to be recognized as mankind. Made for TV as episode 3 of 'Masters of Science Fiction'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Job: A Comedy of Justice",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1984,
                    Type = BookType.Novel,
                    Description = "1985 Hugo Award (Novel): Nominated, 1985 Locus Award (Fantasy Novel): Won, 1985 Nebula Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Larger than Life: A Tribute to E. E. \"Doc\" Smith",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Last Days of the United States",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "Let There Be Light (Heinlein)",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1940,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "Heilein speculates on the implications of solar power. First puplished in Super Science Stories in May, 1940 under the pseudonym Lyle Monroe.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Life-Line",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Robert Heinlein",
                    PublicationYear = 1939,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "A scientist develops a device that can determine the time of one's birth and death. Heinlein's first published story, first published in Astounging Magazine in August, 1939. There's a black and white short film of this story but I haven't seen it.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Logic of Empire",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "The Long Watch",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "Originally titled 'Rebellion on the Moon', appeared in American Legion Magazine in 1949, then Nebula Science Fiction in 1955. Connected more with 'Space Cadet' than other Future History. Referenced in Starship Troopers.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Lost Legacy",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1941,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Lost Legion. A group of adept humans withdrawl from society to live in a cave. First Published in November 1941 issue of Super Science stories under the psudonym Lyle Monroe, after being rejected from Astounding.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Assignment in Eternity" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Magic, Inc.",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Devil Makes the Law, 2016 Hugo Award (Retro Hugos: Novella): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: Waldo & Magic, Inc." }
                    }
                },
                new Book
                {
                    Title = "The Man Who Sold the Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "1952 Analog Award (All-Time Best Book): 4th Place, 2001 Hugo Award (Retro Hugos: Novella): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" },
                        new Tag { Name = "Collection: The Robert Heinlein Omnibus" }
                    },
                },
                new Book
                {
                    Title = "The Man Who Sold the Moon (Collection)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.Forward,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "The Man Who Traveled in Elephants",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Elephant Circuit",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" }
                    }
                },
                new Book
                {
                    Title = "The Menace from Earth",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Methuselah's Children (Short Story)",
                    Author = "Robert A. Heinlein",  
                    PublicationYear = 1941,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "Originally published in Astounding Science Fiction in July, August, and September 1941, then lengthened and published as a novel in 1958",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Methuselah's Children (Novel)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "Originally a serialized novella in 1941, 1997 Prometheus Award (Hall of Fame Award): Won"
                },
                new Book
                {
                    Title = "Misfit",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1939,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "Short story about a Space Marine cadet, who would later appear in other novels. Mistfit was first published in Astounding Science Fiction in November, 1939. Published as part of 'Revolt in 2100' and in 'The Past Through Tomorrow'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: Revolt in 2100" }
                    }
                },
                new Book
                {
                    Title = "The Moon Is a Harsh Mistress",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1966,
                    Type = BookType.Novel,
                    Description = "1967 Hugo Award (Novel): Won, 1975 Locus Award (All-Time Best Novel): Nominated, 1967 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Hall of Fame Award): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated"
                },
                new Book
                {
                    Title = "My Object All Sublime",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1942,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "A man uses a device to become invisible. First published in Future Magazine in February, 1942 under the pseudonym Lyle Monroe, Heinlein did not include this story in any collections during his lifetime",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "No Bands Playing, No Flags Flying",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.NonFiction,
                    Description = "Written in 1947, published in 1973",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "The Notebooks of Lazarus Long",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1978,
                    Type = BookType.ShortStory,
                    Description = "Exceprts from the novel Time Enough for Love."
                },
                new Book
                {
                    Title = "Nothing Ever Happens on the Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Number of the Beast",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1981,
                    Type = BookType.Novel,
                    Description = "1981 Locus Award (SF Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "On the Slopes of Vesuvius",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Ordeal in Space",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Our Fair City",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Pandora's Box",
                    Author = "Robert A. Heinlein",
                    Type = BookType.Forward,
                    Description = "",
                    PublicationYear = 1966,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Paul Dirac, Anitmatter, and You",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Two articles for Encyclopædia Britannica on Paul Dirac and antimatter, and on blood chemistry.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Pie From the Sky",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "Pied Piper",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "Heinlein did not include this story in any collections during his lifetime",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Podkayne of Mars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = "Based on his character Maureen from the Puddin' series he wrote for girls. Republished in 1995 with an alternate ending.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "Poor Daddy",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "R. A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "This one one of Heinlein's few stories for girls, set in then modern times, first published in Calling All Girls magazine in 1949.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "The Pragmatics of Patriotism",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Pravda Means Truth",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Project Nightmare",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "The Puppet Masters",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "Re-published posthumously with excisions restored, 1990. Made into a movie in 1994 starring Donald Sutherland.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: A Heinlein Trio" }
                    }
                },
                new Book
                {
                    Title = "The Pursuit of the Pankera",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2020,
                    Type = BookType.Novel,
                    Description = "Previously unpublished, this is an alternate version of The Number of the Beast with roughly the first third of the story being the same.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" },
                        new Tag { Name = "Posthumous" }
                    }
                },
                new Book
                {
                    Title = "Ray Guns and Rocket Ships",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Red Planet",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.Novel,
                    Description = "Addapted into a children's animated TV series in 1994. Won the 1996 Prometheus Award (Hall of Fame)",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "Requiem",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "An old man achieves his dream of travelling to the Moon in this short story sequel to 'The Man Who Sold the Moon'. Won the 2003 Prometheus Award (Hall of Fame Award) and was nominated for the 2016 Retro Hugo Award for Short Story",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" },
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "The Roads Must Roll",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "An engineer must keep the roads rolling in this early Heinlein story about future technology. First published in Astounging Magazine in August, 1940. 2016 Hugo Award (Retro Hugos: Novelette): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Man Who Sold the Moon" }
                    }
                },
                new Book
                {
                    Title = "Rocket Ship Galileo",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.Novel,
                    Description = "A story of three boys who travel to the Moon.",
                    Tags = new List<Tag> 
                    { 
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    }
                },
                new Book
                {
                    Title = "The Rolling Stones",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "a.k.a. Space Family Stone / 2006 Audie Awards (Science Fiction): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Searchlight",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Shooting Destination Moon",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1950,
                    Type = BookType.NonFiction,
                    Description = "First appeared in July 1950 Astounding Science Fiction magazine.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "Sixth Column",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.Novel,
                    Description = "a.k.a. The Day After Tomorrow / Initially serialized in 1941, and at that time credited to Anson MacDonald."
                },
                new Book
                {
                    Title = "Sky Lift",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Solution Unsatisfactory",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1941,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "Heinlein anticpates the nuclear arms race. First published in Astounding Science Fiction in May, 1941 under the pseudonym Anson MacDonald.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Worlds of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Space Cadet",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1948,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Four Frontiers" }
                    },
                    Description = ""
                },
                new Book
                {
                    Title = "Space Jockey",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Spinoff",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1980,
                    Type = BookType.NonFiction,
                    Description = "An article based on Heinlein's testimony to the US Congress about the commercialization of inventions created for NASA and the American space program. Published in Omni magazine in 1980; reprinted in Expanded Universe.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Star Beast",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1954,
                    Type = BookType.Novel,
                    Description = "2008 Audie Awards (Audio Drama): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Starman Jones",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1953,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: To The Stars" }
                    }
                },
                new Book
                {
                    Title = "Starship Troopers",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1959,
                    Type = BookType.Novel,
                    Description = "Won the 1960 Hugo Award for Best Novel. Heinlein considered this a Juvenile novel, but opinions vary. Made into a movie by Paul Verhoeven in 1997 starring Denise Richards, Casper Van Dien, and Dina Meyer.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: Outward Bound" }
                    }
                },
                new Book
                {
                    Title = "Stranger in a Strange Land",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1961,
                    Type = BookType.Novel,
                    Description = "Reprinted at the original greater length in 1991, 1962 Hugo Award (Novel): Won, 1975 Locus Award (All-Time Best Novel): Nominated, 1987 Prometheus Award (Hall of Fame Award): Won, 1987 Locus Award (All-Time Best SF Novel): Nominated, 1990 Science Fiction Book Club's Book of the Year Award: Nominated"
                },
                new Book
                {
                    Title = "Successful Operation",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Lyle Monroe",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Heil! A surgeon is forced to perform an operation. First published in Futuria Fantasies, Spring 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    },
                },
                new Book
                {
                    Title = "Take Back Your Government: A Practical Handbook for the Private Citizen",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "Originally published as How to Be a Politician"
                },
                new Book
                {
                    Title = "A Tenderfoot in Space",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "Serialized in 1958",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Requiem" }
                    }
                },
                new Book
                {
                    Title = "They",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "A man is convinced his universe is being controlled by others. First published in 'Unknown' magazine in April, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "They Do It with Mirrors",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Simon York",
                    PublicationYear = 1947,
                    Type = BookType.NonFiction,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 1" }
                    },
                },
                new Book
                {
                    Title = "The Third Millennium Open",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    Description = "",
                    PublicationYear = 1980,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "Time Enough for Love",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1973,
                    Type = BookType.Novel,
                    Description = "1974 Locus Award (SF Novel): Nominated, 1974 Hugo Award (Novel): Nominated, 1974 Nebula Award (Novel): Nominated, 1983 Prometheus Award (Novel): Nominated"
                },
                new Book
                {
                    Title = "Time for the Stars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "To Sail Beyond the Sunset",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1987,
                    Type = BookType.Novel,
                    Description = "1988 Locus Award (SF Novel): Nominated, 1989 Prometheus Award (Novel): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "World as Myth" }
                    }
                },
                new Book
                {
                    Title = "Tomorrow, the Stars",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.Forward,
                    Description = "Anthology of stories by 14 authors selected by Frederik Pohl and Judith Merril, foreword by Heinlein who got his name on the cover."
                },
                new Book
                {
                    Title = "Tramp Royale",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "Heinlein's travelogue from travelling in the 50s.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Posthumous" }
                    }
                },
                new Book
                {
                    Title = "Tunnel in the Sky",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1955,
                    Type = BookType.Novel,
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" },
                        new Tag { Name = "Collection: Infinite Possibilities" }
                    }
                },
                new Book
                {
                    Title = "Universe",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "A young man named Hugh Hoyland discovers he is living on a gigantic spaceship stopped in space. First published in Astounding Science Fiction in May 1941, then as one half of Orphans in the Sky in 1963.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: Orphans of the Sky" }
                    }
                },
                new Book
                {
                    Title = "The Unpleasant Profession of Jonathan Hoag",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "John Riverside",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novella): Nominated",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: The Unpleasant Profession of Jonathan Hoag (6xH)" }
                    }
                },
                new Book
                {
                    Title = "Variable Star",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2006,
                    Type = BookType.Novel,
                    Description = "With Spider Robinson; Heinlein's eight page outline written in 1955; Robinson's full novel from the outline appeared in 2006"
                },
                new Book
                {
                    Title = "Waldo",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novella): Won",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Fantasies of Robert A. Heinlein" },
                        new Tag { Name = "Collection: Three by Heinlein" },
                        new Tag { Name = "Collection: Waldo & Magic, Inc." }
                    }
                },
                new Book
                {
                    Title = "Water Is for Washing",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "We Also Walk Dogs",
                    Author = "Robert A. Heinlein",
                    WrittenAs = "Anson MacDonald",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: A Robert Heinlein Omnibus" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" },
                        new Tag { Name = "Collection: The Green Hills of Earth" }
                    }
                },
                new Book
                {
                    Title = "Where To?",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Galaxy magazine, 1950, 1965, 1980",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    }
                },
                new Book
                {
                    Title = "Who are the Heirs of Patrick Henry?",
                    Author = "Robert A. Heinlein",
                    Type = BookType.NonFiction,
                    PublicationYear = 1958,
                    Description = "Printed as a paid ad in Colorado Springs Gazette in 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Expanded Universe Vol. 2" }
                    },
                },
                new Book
                {
                    Title = "The Witch's Daughters",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.Poem,
                    Description = "First published in New Destinies vol VI in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Requiem" }
                    },
                },
                new Book
                {
                    Title = "The Year of the Jackpot",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Menace from Earth" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Dance Session",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1946,
                    Type = BookType.Poem,
                    Description = "Love poem",
                },
                new Book
                {
                    Title = "The Green Hills of Earth (Poem)",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2003,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Atlantis",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2007,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "The Last Adventure",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2007,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Brave New World",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Death Song of a Wood's Colt",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "This poem is used 14 years after it was written in Stranger in a Strange Land with one line changed: instead of My sandy burning eyeballs, as the light within them dims of the original, Stranger uses, sanded burning eyeballs, as light within them dims.",
                },
                new Book
                {
                    Title = "Three Wise Mice",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Untitled Poem Fragment",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 2011,
                    Type = BookType.Poem,
                    Description = "",
                },
                new Book
                {
                    Title = "Encyclopædia Britannica",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "Two articles for Encyclopædia Britannica on Paul Dirac and antimatter, and on blood chemistry.",
                },


                // Arthur C. Clarke
                new Book
                {
                    Title = "2001: A Space Odyssey",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1968,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Space Odyssey" }
                    }
                },
                new Book
                {
                    Title = "2010: Odyssey Two",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1982,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Space Odyssey" }
                    }
                },
                new Book
                {
                    Title = "2061: Odyssey Three",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1987,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Space Odyssey" }
                    }
                },
                new Book
                {
                    Title = "3001: The Final Odyssey",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1997,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Space Odyssey" }
                    }
                },
                new Book
                {
                    Title = "Rendezvous with Rama",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1973,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Rama" },
                        new Tag { Name = "Collection: Four Great SF Novels" }
                    }
                },
                new Book
                {
                    Title = "Rama II",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "with Gentry Lee",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Rama" }
                    }
                },
                new Book
                {
                    Title = "The Garden of Rama",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1991,
                    Type = BookType.Novel,
                    Description = "with Gentry Lee",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Rama" }
                    }
                },
                new Book
                {
                    Title = "Rama Revealed",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Novel,
                    Description = "with Gentry Lee",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Rama" }
                    }
                },
                new Book
                {
                    Title = "Time's Eye",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2003,
                    Type = BookType.Novel,
                    Description = "with Stephen Baxter",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Time Odyssey" }
                    }
                },
                new Book
                {
                    Title = "Sunstorm",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2005,
                    Type = BookType.Novel,
                    Description = "with Stephen Baxter",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Time Odyssey" }
                    }
                },
                new Book
                {
                    Title = "Firstborn",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2007,
                    Type = BookType.Novel,
                    Description = "with Stephen Baxter",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Time Odyssey" }
                    }
                },
                new Book
                {
                    Title = "Against the Fall of Night",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1948,
                    Type = BookType.Novel,
                    Description = "original version of The City and the Stars"
                },
                new Book
                {
                    Title = "Prelude to Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "Reprinted in 1961 as Master of Space and as The Space Dreamers in 1969.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: An Arthur C. Clarke Omnibus" }
                    }
                },
                new Book
                {
                    Title = "The Sands of Mars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: An Arthur C. Clarke Second Omnibus" },
                        new Tag { Name = "Collection: The Space Trilogy" }
                    }
                },
                new Book
                {
                    Title = "Islands in the Sky",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Space Trilogy" }
                    }
                },
                new Book
                {
                    Title = "Childhood's End",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.Novel,
                    Description = "Adapted into a 2015 miniseries on Syfy.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: An Arthur C. Clarke Omnibus" }
                    }
                },
                new Book
                {
                    Title = "Earthlight (Novel)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1955,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Space Trilogy" }
                    }
                },
                new Book
                {
                    Title = "The City and the Stars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: From the Ocean, From the Stars" },
                        new Tag { Name = "Collection: Four Great SF Novels" }
                    }
                },
                new Book
                {
                    Title = "The Deep Range (Novel)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: From the Ocean, From the Stars" },
                        new Tag { Name = "Collection: Four Great SF Novels" }
                    }
                },
                new Book
                {
                    Title = "A Fall of Moondust",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.Novel,
                    Description = "Hugo nominee, 1963",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: An Arthur C. Clarke Second Omnibus" },
                        new Tag { Name = "Collection: Four Great SF Novels" },
                        new Tag { Name = "Collection: Clarke's Universe" }
                    }
                },
                new Book
                {
                    Title = "Dolphin Island",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = ""
                },
                new Book
                {
                    Title = "Glide Path",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = ""
                },
                new Book
                {
                    Title = "Imperial Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1975,
                    Type = BookType.Novel,
                    Description = ""
                },
                new Book
                {
                    Title = "The Fountains of Paradise",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1979,
                    Type = BookType.Novel,
                    Description = "Hugo and Nebula Award winner, 1979."
                },
                new Book
                {
                    Title = "The Songs of Distant Earth (Novel)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1986,
                    Type = BookType.Novel,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" }
                    }
                },
                new Book
                {
                    Title = "Cradle",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1988,
                    Type = BookType.Novel,
                    Description = "with Gentry Lee"
                },
                new Book
                {
                    Title = "Beyond the Fall of Night",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1990,
                    Type = BookType.Novel,
                    Description = "First part a reprint of Against the Fall of Night, second part a sequel by Gregory Benford"
                },
                new Book
                {
                    Title = "The Ghost from the Grand Banks",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1990,
                    Type = BookType.Novel,
                    Description = ""
                },
                new Book
                {
                    Title = "The Hammer of God (Novel)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Novel,
                    Description = ""
                },
                new Book
                {
                    Title = "Richter 10",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1996,
                    Type = BookType.Novel,
                    Description = "with Mike McQuay"
                },
                new Book
                {
                    Title = "The Trigger",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1999,
                    Type = BookType.Novel,
                    Description = "with Michael P. Kube-McDowell"
                },
                new Book
                {
                    Title = "The Light of Other Days",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2000,
                    Type = BookType.Novel,
                    Description = "with Stephen Baxter"
                },
                new Book
                {
                    Title = "The Last Theorem",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2008,
                    Type = BookType.Novel,
                    Description = "with Frederik Pohl"
                },
                new Book
                {
                    Title = "Travel by Wire!",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1937,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "How We Went to Mars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1938,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Retreat from Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1938,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "At the Mountains of Murkiness",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = ""
                },
                new Book
                {
                    Title = "The Awakening",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "revised edition published in 1952",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Whacky",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1942,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Lion of Comarre",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1945,
                    Type = BookType.ShortStory,
                    Description = "novella",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: Clarke's Universe" }
                    }
                },
                new Book
                {
                    Title = "Loophole",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Rescue Party",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Technical Error",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1946,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Reversed Man",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Castaway",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Inheritance",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Nightfall (Clarke)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1947,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Curse",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Breaking Strain",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Thirty Seconds - Thirty Days",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Fires Within",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Forgotten Enemy",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Hide-and-Seek",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "History Lesson",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Expedition to Earth",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" },
                        new Tag { Name = "Collection: An Arthur C. Clarke Omnibus" }
                    }
                },
                new Book
                {
                    Title = "Transience",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Wall of Darkness",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Guardian Angel",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Exile of the Eons",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Nemesis",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Road to the Sea",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Seeker of the Sphinx",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Time's Arrow",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "A Walk in the Dark",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "All the Time in the World",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Earthlight (Short Story)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "extended into the novel Earthlight in 1955",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: An Arthur C. Clarke Second Omnibus" }
                    }
                },
                new Book
                {
                    Title = "Holiday on the Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "If I Forget Thee, Oh Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Second Dawn",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Sentinel",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Superiority",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Trouble with the Natives",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Encounter in the Dawn",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Encounter at Dawn a.k.a. Expedition to Earth",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Expedition to Earth" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Jupiter Five",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Jupiter V",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: Clarke's Universe" }
                    }
                },
                new Book
                {
                    Title = "The Nine Billion Names of God",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "Made into a 2018 French short film.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Other Tiger",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Parasite",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Possessed",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Publicity Campaign",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Reverie",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1953,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Armaments Race",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Deep Range (Short Story)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "extended into the novel The Deep Range in 1957",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Man Who Ploughed the Sea",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "No Morning After",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Patent Pending",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Silence Please",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Silence Please!",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Refugee",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. ?, a.k.a. Royal Prerogative, a.k.a. This Earth of Majesty",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Star",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1955,
                    Type = BookType.ShortStory,
                    Description = "Adapted into episode 13 of the 1985 Twilight Zone.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "What Goes Up",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1955,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. What Goes Up...",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "All that Glitters",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. All That Glitters",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Big Game Hunt",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Reckless Ones",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Green Fingers",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Pacifist",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "A Question of Residence",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Reluctant Orchid",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Robin Hood, F.R.S.",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Starting Line",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Venture to the Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "six individual connected short stories",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Watch this Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.ShortStory,
                    Description = "under the titles \"V: Watch this Space\" and \"Who Wrote That Message to the Stars? ...in Letters a Thousand Miles Long?\", 1957 as \"Watch This Space\"",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Venture to the Moon" },
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Call of the Stars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Cold War",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Critical Mass",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Defenestration of Ermintrude Inch",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Let There Be Light (Clarke)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Freedom of Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Moving Spirit",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Next Tenants",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Other Side of the Sky",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "six individual connected stories",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: From the Ocean, From the Stars" }
                    }
                },
                new Book
                {
                    Title = "Passer-by",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Security Check",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Sleeping Beauty",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Songs of Distant Earth (Short Story)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Special Delivery",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Feathered Friend",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Feathered Friends",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Take a Deep Breath",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Ultimate Melody",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales from the White Hart" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Cosmic Casanova",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "A Slight Case of Sunstroke",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Stroke of the Sun",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Out from the Sun",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Out of the Sun?",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Other Side of the Sky" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Who's There?",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Haunted Spacesuit",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Out of the Cradle, Endlessly Orbiting...",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1959,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Out of the Cradle",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Into the Comet",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Inside the Comet",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "I Remember Babylon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Summertime on Icarus",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Hottest Piece of Real Estate in the Solar System",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Trouble with Time",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Crime on Mars",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Before Eden",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Death and the Senator",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Food of the Gods",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Hate",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. At the End of the Orbit",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Love that Universe",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" }, 
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Saturn Rising",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "An Ape About the House",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: Of Time and Stars" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Dog Star",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Moon Dog",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales of Ten Worlds" },
                        new Tag { Name = "Collection: The Nine Billion Names of God" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Maelstrom II",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Shining Ones",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Last Command",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1963,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Playback",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1963,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Secret",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1963,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. The Secret of the Men in the Moon",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Light of Darkness",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1964,
                    Type = BookType.ShortStory,
                    Description = "An assassin plots to remove the dictator of his African country.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Wind from the Sun",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1964,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Sunjammer",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Dial F for Frankenstein",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1965,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Longest Science-Fiction Story Ever Told",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1966,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. A Recursion in Metastories",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Cruel Sky",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1966,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Crusade",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1966,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Herbert George Morley Roberts Wells, Esq.",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1967,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Neutron Tide",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1970,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Transit of Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1971,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "A Meeting with Medusa",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1971,
                    Type = BookType.ShortStory,
                    Description = "Nebula Award for best novella",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: The Sentinel" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" },
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Reunion",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1971,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" },
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "When the Twerms Came",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.ShortStory,
                    Description = "Originally appeared in The View from Serendip, reprinted in the 1987 edition of The Wind from the Sun.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: More Than One Universe" }
                    }
                },
                new Book
                {
                    Title = "Quarantine",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "siseneG",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: More Than One Universe" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "On Golden Seas",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1986,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" },
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Steam-Powered Word Processor",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1986,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Hammer of God (Short Story)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1992,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "The Wire Continuum",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1997,
                    Type = BookType.ShortStory,
                    Description = "with Stephen Baxter",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Improving the Neighbourhood",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1999,
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Reach for Tomorrow",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.Forward,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Reach for Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Of Time and Stars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.Forward,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Of Time and Stars" }
                    }
                },
                new Book
                {
                    Title = "The Wind from the Sun (Collection)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.Forward,
                    Description = "",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Wind from the Sun" }
                    }
                },
                new Book
                {
                    Title = "Of Sand and Stars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1983,
                    Type = BookType.Forward,
                    Description = "Introduction to The Sentinel collection",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Sentinel" }
                    }
                },
                new Book
                {
                    Title = "Tales From Planet Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.Forward,
                    Description = "With Isaac Asimov",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: Tales From Planet Earth" }
                    }
                },
                new Book
                {
                    Title = "The Collected Stories of Arthur C. Clarke",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Introduction written by Clarke before his death in 2000.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Collected Stories of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "1933: A Science Fiction Odyssey",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1973,
                    Type = BookType.Forward,
                    Description = "The best of Arthur C. Clarke was an anthology published in 1973.",
                    Tags = new List<Tag> { 
                        new Tag { Name = "Collection: The Best of Arthur C. Clarke" }
                    }
                },
                new Book
                {
                    Title = "Interplanetary Flight: An Introduction to Astronautics",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1950,
                    Type = BookType.NonFiction,
                    Description = ""
                },
                new Book
                {
                    Title = "The Exploration of Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1951,
                    Type = BookType.NonFiction,
                    Description = "Updated/revised 1959 and 1979 (with a new introduction)."
                },
                new Book
                {
                    Title = "The Exploration of the Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.NonFiction,
                    Description = "Illustrated by R.A. Smith."
                },
                new Book
                {
                    Title = "The Young Traveller in Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1954,
                    Type = BookType.NonFiction,
                    Description = "Variously titled Going into Space. New York: Harper and Row, 1954, The Scottie Book of Space Travel. London: Transworld Publishers, 1957"
                },
                new Book
                {
                    Title = "The Coast of Coral",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1956,
                    Type = BookType.NonFiction,
                    Description = "Volume 1 of the Blue Planet Trilogy"
                },
                new Book
                {
                    Title = "The Reefs of Taprobane; Underwater Adventures around Ceylon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.NonFiction,
                    Description = "Volume 2 of the Blue Planet Trilogy"
                },

                new Book
                {
                    Title = "The Making of a Moon: The Story of the Earth Satellite Program",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1957,
                    Type = BookType.NonFiction,
                    Description = ""
                },
                new Book
                {
                    Title = "Boy Beneath the Sea",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.NonFiction,
                    Description = "Photos by Mike Wilson. Text by Arthur C. Clarke. New York: Harper, 1958"
                },
                new Book
                {
                    Title = "Voice Across the Sea",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1958,
                    Type = BookType.NonFiction,
                    Description = "HarperCollins, 1958"
                },
                new Book
                {
                    Title = "The Challenge of the Space Ship: Previews of Tomorrow’s World",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1959,
                    Type = BookType.NonFiction,
                    Description = "New York: Harper, 1959"
                },
                new Book
                {
                    Title = "The Challenge of the Sea",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "New York: Holt, Rinehart and Winston, 1960"
                },
                new Book
                {
                    Title = "The First Five Fathoms",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "Photos by Mike Wilson. Text by Arthur C. Clarke. New York: Harper, 1960"
                },
                new Book
                {
                    Title = "Indian Ocean Adventure",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1961,
                    Type = BookType.NonFiction,
                    Description = "Photos by Mike Wilson. Text by Arthur C. Clarke. New York: Harper, 1961"
                },
                new Book
                {
                    Title = "Profiles of the Future; an Inquiry into the Limits of the Possible",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "London: Gollancz, 1962. Updated editions of this book were printed in 1973, 1984 and in 1999 as the \"Millennium Edition\"."
                },
                new Book
                {
                    Title = "Man and Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "1964. Created with the editors of Life."
                },
                new Book
                {
                    Title = "Indian Ocean Treasure",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "Photos by Mike Wilson. Text by Arthur C. Clarke. New York: Harper, 1964"
                },
                new Book
                {
                    Title = "The Treasure of the Great Reef",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "Photos by Mike Wilson. Text by Arthur C. Clarke. New York: Harper & Row, 1964"
                },
                new Book
                {
                    Title = "Voices from the Sky: Previews of the Coming Space Age",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "New York: Harper & Row, 1965"
                },
                new Book
                {
                    Title = "The Promise of Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "New York: Harper, 1968"
                },
                new Book
                {
                    Title = "Into Space: a Young Person's Guide to Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "New York: Harper & Row, 1971"
                },
                new Book
                {
                    Title = "Beyond Jupiter: The Worlds of Tomorrow",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "Little & Brown, 1972"
                },
                new Book
                {
                    Title = "Report on Planet Three and Other Speculations",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "New York: Harper & Row, 1972"
                },
                new Book
                {
                    Title = "The Lost Worlds of 2001",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "London: Sidgwick and Jackson, 1972"
                },
                new Book
                {
                    Title = "The View from Serendip",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "Random House, 1977"
                },
                new Book
                {
                    Title = "The Odyssey File",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "Email correspondence with Peter Hyams. London: Panther Books, 1984"
                },
                new Book
                {
                    Title = "1984, Spring: a Choice of Futures",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "New York: Ballantine Books, 1984"
                },
                new Book
                {
                    Title = "Ascent to Orbit, a Scientific Autobiography: The Technical Writings of Arthur C. Clarke",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "New York: John Wiley & Sons, 1984"
                },
                new Book
                {
                    Title = "20 July 2019: Life in the 21st Century",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "Macmillan Publishing Company, 1986"
                },
                new Book
                {
                    Title = "Astounding Days: A Science Fictional Autobiography",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "London: Gollancz, 1989"
                },
                new Book
                {
                    Title = "How the World Was One: Beyond the Global Village (a.k.a. How the World Was One: Towards the Tele-Family of Man)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "London : Gollanncz, 1992 — A history and survey of the communications revolution"
                },
                new Book
                {
                    Title = "By Space Possessed",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.NonFiction,
                    Description = "London: Gollancz, 1993"
                },
                new Book
                {
                    Title = "The Snows of Olympus - A Garden on Mars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1994,
                    Type = BookType.NonFiction,
                    Description = "London: Gollancz 1994, picture album with comments"
                },
                new Book
                {
                    Title = "Childhood Ends: The Earliest Writings of Arthur C. Clarke",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1996,
                    Type = BookType.NonFiction,
                    Description = "Rochester: Portentous Press, 1996"
                },
                new Book
                {
                    Title = "Greetings, Carbon-Based Bipeds! : Collected Works 1934-1988",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1999,
                    Type = BookType.NonFiction,
                    Description = "London: HarperCollins, 1999"
                },
                new Book
                {
                    Title = "Extra-Terrestrial Relays in Wireless World",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1945,
                    Type = BookType.NonFiction,
                    Description = "Article published in Wireless World in October 1945"
                },
                new Book
                {
                    Title = "From the Earth to the Moon by Jules Verne",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1962,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to the 1962 edition of this 1865 novel."
                },
                new Book
                {
                    Title = "Time Probe: The Sciences in Science Fiction",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1966,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction and one story, collected the other ten stories."
                },
                new Book
                {
                    Title = "The Coming of the Space Age; Famous Accounts of Man's Probing of the Universe",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1967,
                    Type = BookType.Forward,
                    Description = "Selected and edited by Arthur C. Clarke."
                },
                new Book
                {
                    Title = "The Beginnings of Satellite Communication",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1968,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. J.R. Pierce, 1968."
                },
                new Book
                {
                    Title = "Three for Tomorrow",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1969,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Robert Silverberg, Roger Zelazny and James Blish, 1969."
                },
                new Book
                {
                    Title = "First on the Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1970,
                    Type = BookType.Forward,
                    Description = "Wrote Epilogue. Neil Armstrong with Gene Farmer and Dora Jane Hamblin, 1970."
                },
                new Book
                {
                    Title = "The Panic Broadcast",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1970,
                    Type = BookType.Forward,
                    Description = "Introductory interview with Arthur C. Clarke. Howard Koch, 1970."
                },
                new Book
                {
                    Title = "The Challenge of the Stars",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1972,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. 1972."
                },
                new Book
                {
                    Title = "The World in Focus",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1974,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. William MacQuitty, 1974."
                },
                new Book
                {
                    Title = "The Complete Venus Equilateral",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1976,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. George O. Smith, 1976."
                },
                new Book
                {
                    Title = "The Telephone's First Century—and Beyond: Essays on the Occasion of the 100th Anniversary of Telephone Communication",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1974,
                    Type = BookType.Forward,
                    Description = "Wrote Essay. 1974."
                },
                new Book
                {
                    Title = "The World in Color Photography",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1979,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. 1979."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Mysterious World",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1980,
                    Type = BookType.Forward,
                    Description = "Wrote chapter introductions. Simon Welfare and John Fairly, 1980."
                },
                new Book
                {
                    Title = "The Illustrated Encyclopedia of Space Technology",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1981,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. 1981."
                },
                new Book
                {
                    Title = "The Science Fiction Hall of Fame Volume Three: The Nebula Winners 1965-1969",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1982,
                    Type = BookType.Forward,
                    Description = "Editor along with George Proctor."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's World of Strange Powers",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1984,
                    Type = BookType.Forward,
                    Description = "Wrote chapter introductions. Simon Welfare and John Fairly, 1984."
                },
                new Book
                {
                    Title = "Sightseeing: A Space Panorama",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1985,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Barbara Hitchcock, 1985."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Chronicles of the Strange and Mysterious",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1987,
                    Type = BookType.Forward,
                    Description = "Wrote chapter introductions. Simon Welfare and John Fairly, 1987."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 1: Breaking Strain",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1987,
                    Type = BookType.Forward,
                    Description = "Wrote Afterword; novel is based on Clarke's short story Breaking Strain."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 2: Maelstrom",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1988,
                    Type = BookType.Forward,
                    Description = "Wrote Afterword; novel is based on Clarke's short story Maelstrom II."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 3: Hide and Seek",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1989,
                    Type = BookType.Forward,    
                    Description = "Wrote Afterword; novel is based on Clarke's short story Hide-and-Seek."
                },
                new Book
                {
                    Title = "Visions of Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1989,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 4: The Medusa Encounter",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1990,
                    Type = BookType.Forward,
                    Description = "Wrote Afterword; novel is based on Clarke's short story A Meeting with Medusa."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 5: The Diamond Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1990,
                    Type = BookType.Forward,
                    Description = "Wrote Afterword; novel is based on Clarke's short story Jupiter Five."
                },
                new Book
                {
                    Title = "Project Solar Sail",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1990,
                    Type = BookType.Forward,
                    Description = "Editor."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Venus Prime Vol. 6: The Shining Ones",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1991,
                    Type = BookType.Forward,
                    Description = "Wrote Afterword; novel is based on Clarke's short story The Shining Ones."
                },
                new Book
                {
                    Title = "Blueprint for Space: Science Fiction to Science Fact",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1991,
                    Type = BookType.Forward,
                    Description = "Wrote Epilogue. Frederick I. Ordway III, 1991."
                },
                new Book
                {
                    Title = "Sri Lanka",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1991,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Tom Tidball, 1991."
                },
                new Book
                {
                    Title = "Space Commerce",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1991,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. John L. McLucas, 1991."
                },
                new Book
                {
                    Title = "The Profession of Science Fiction: SF Writers on Their Craft and Ideas",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1992,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Maxim Jakubowski, 1992."
                },
                new Book
                {
                    Title = "Technology 2001: The Future of Computing and Communications",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1992,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Derek Leebaert, 1992."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's A-Z of Mysteries",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote foreword. Simon Welfare and John Fairly, 1993."
                },
                new Book
                {
                    Title = "The Anti-Gravity Handbook (New and Expanded Edition)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Chapter 1, titled 'Arthur C. Clarke on Anti-Gravity'. D. Hatcher Childress (compiler), 1993."
                },
                new Book
                {
                    Title = "The Dream Machines: An Illustrated History of the Spaceship in Art, Science and Literature",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Ron Miller and Rick Dunning, 1993."
                },
                new Book
                {
                    Title = "The First Men in the Moon",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to the 1993 edition of this 1901 novel."
                },
                new Book
                {
                    Title = "Unearthing Atlantis: An Archaeological Odyssey to the Fabled Lost Civilization",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Charles R. Pellegrino, 1993."
                },
                new Book
                {
                    Title = "Seize the Moment: The Autobiography of Britain's First Astronaut",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Helen Sharman, 1993."
                },
                new Book
                {
                    Title = "The War of the Worlds",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1993,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to the 1993 edition of this 1898 novel."
                },
                new Book
                {
                    Title = "Gene Roddenberry: The Last Conversation",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1994,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Yvonne Fern, 1994."
                },
                new Book
                {
                    Title = "The Millennial Project: Colonizing the Galaxy in Eight Easy Steps",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1994,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Marshall T. Savage, 1994."
                },
                new Book
                {
                    Title = "Only Visiting This Planet: The Art of Danny Flynn",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1994,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Nigel Suckling, 1994."
                },
                new Book
                {
                    Title = "The Ultimate Egoist",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1994,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Theodore Sturgeon, 1994."
                },
                new Book
                {
                    Title = "2001: Filming the Future",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Piers Bizony, 1995."
                },
                new Book
                {
                    Title = "Aliya: Stories of the Elephants of Sri Lanka",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Teresa Cannon and Peter Davis, 1995."
                },
                new Book
                {
                    Title = "Bright Messengers",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to this novel set in the Rama universe."
                },
                new Book
                {
                    Title = "An Encyclopedia of Claims, Frauds, and Hoaxes of the Occult and Supernatural (a.k.a. The Supernatural A-Z: The Truth and the Lies)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. James Randi, 1995, St. Martin's Press ISBN 0-312-15119-5 (Online Version)."
                },
                new Book
                {
                    Title = "Frontline of Discovery: Science on the Brink of Tomorrow",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Epilogue. National Geographic Society, 1995."
                },
                new Book
                {
                    Title = "Rogue Asteroids and Doomsday Comets:The Search for the Million Megaton Menace That Threatens Life on Earth",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1995,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Duncan Steel, 1995."
                },
                new Book
                {
                    Title = "The Dechronization of Sam Magruder",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1996,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. George Gaylord Simpson, 1996."
                },
                new Book
                {
                    Title = "Encounter with Tiber",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1996,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Buzz Aldrin and John Barnes, 1996."
                },
                new Book
                {
                    Title = "Survival Kit: How to Reach Ninety and Make the Most of It",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1996,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. William MacQuitty, 1996."
                },
                new Book
                {
                    Title = "The Case for Mars: The Plan to Settle the Red Planet and Why We Must",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1997,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Robert Zubrin and Richard Wagner, 1997."
                },
                new Book
                {
                    Title = "The Roving Mind: New Edition",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1997,
                    Type = BookType.Forward,
                    Description = "Wrote Tribute. Isaac Asimov, 1997."
                },
                new Book
                {
                    Title = "Arthur C. Clarke & Lord Dunsany: A Correspondence",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1998,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Keith Allen Daniels, 1998."
                },
                new Book
                {
                    Title = "Hal's Legacy : 2001's Computer As Dream and Reality",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1998,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. David G. Stork, 1998."
                },
                new Book
                {
                    Title = "Intelligent Software Agents",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1998,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Richard Murch and Tony Johnson, 1998."
                },
                new Book
                {
                    Title = "Arthur C. Clarke's Mysteries",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1998,
                    Type = BookType.Forward,
                    Description = "Wrote foreword. Simon Welfare and John Fairly, 1998 and 2000."
                },
                new Book
                {
                    Title = "Welcome to the Wired World: The New Networked Economy",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 1999,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. Anne C. Leer, 1999."
                },
                new Book
                {
                    Title = "e-Sphere: The Rise of the World-Wide Mind",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2000,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Joseph N. Pelton, 2000."
                },
                new Book
                {
                    Title = "Excess Heat: Why Cold Fusion Research Prevailed",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2000,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Charles G. Beaudette, 2000."
                },
                new Book
                {
                    Title = "Sri Lanka, the Emerald Island",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2000,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Tissa Devendra, 2000."
                },
                new Book
                {
                    Title = "The Art of Chesley Bonestell",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Ron Miller, 2001."
                },
                new Book
                {
                    Title = "Literary Trips 2: Following in the Footsteps of Fame",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Victoria Brooks, 2001."
                },
                new Book
                {
                    Title = "Macroshift: Navigating the Transformation to a Sustainable World",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Ervin Laszlo, 2001."
                },
                new Book
                {
                    Title = "The Search for Free Energy (a.k.a. The Scientist, the Madman, the Thief and Their Lightbulb)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Keith Tutt, 2001."
                },
                new Book
                {
                    Title = "Visions of Spaceflight: Images from the Ordway Collection",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction, technical advisor. Frederick I. Ordway III, 2001."
                },
                new Book
                {
                    Title = "The Web Between the Worlds",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to the 2001 edition of this 1979 novel. Charles Sheffield, 2001."
                },
                new Book
                {
                    Title = "The Worlds of Galileo",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2001,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Michael E. Hanlon, 2001."
                },
                new Book
                {
                    Title = "Business 2010: Mapping the New Commercial Landscape",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2002,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Ian Pearson, Michael Lyons, 2002."
                },
                new Book
                {
                    Title = "The Conquest of Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2002,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction to the 2002 edition of this 1931 work of non-fiction. David Lasser, 2002."
                },
                new Book
                {
                    Title = "Creating Space: The Story of the Space Age through the Models",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2002,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Mat Irvine, 2002."
                },
                new Book
                {
                    Title = "Moonwatcher's Memoir: A Diary of 2010: A Space Odyssey",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2002,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Dan Richter, 2002."
                },
                new Book
                {
                    Title = "From Narnia to A Space Odyssey: The War of Ideas Between Arthur C. Clarke and C. S. Lewis",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2003,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Ryder W. Miller, 2003."
                },
                new Book
                {
                    Title = "To the Edge of Doom",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2003,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Tyronne Fernando, 2003."
                },
                new Book
                {
                    Title = "The Colours of Infinity: The Beauty, The Power and the Sense of Fractals",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2004,
                    Type = BookType.Forward,
                    Description = "Contributor. Reprinted in 2010 as The Colours of Infinity: The Beauty and Power of Fractals"
                },
                new Book
                {
                    Title = "Are We Alone?: The Stanley Kubrick Extraterrestrial Intelligence Interviews",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2005,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. Anthony Frewin, 2005."
                },
                new Book
                {
                    Title = "Freedom on the March: An American Voyage to Explore Globalization",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2005,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Patrick Mendis, 2005."
                },
                new Book
                {
                    Title = "'S' Is for Space",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2005,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. Ray Bradbury, 2005."
                },
                new Book
                {
                    Title = "Science Fiction Quotations: From the Inner Mind to the Outer Limits",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2005,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Dr. Gary Westfahl, 2005."
                },
                new Book
                {
                    Title = "Beautiful Living: Buddha's Way to Prosperity, Wisdom, and Inner Peace (a.k.a. The Buddha's Teachings on Prosperity: At Home, At Work, In the World)",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2006,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Bhikkhu Rahula, 2006."
                },
                new Book
                {
                    Title = "Jules Verne: The Definitive Biography",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2006,
                    Type = BookType.Forward,
                    Description = "Wrote Introduction. William Butcher, 2006."
                },
                new Book
                {
                    Title = "The World of Jules Verne",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2006,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. Gonzague Saint Bris, 2006."
                },
                new Book
                {
                    Title = "The Rise of Animals: Evolution and Diversification of the Kingdom Animalia",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2008,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Mikhail A. Fedonkin, James G. Gehling, Kathleen Grey, Guy M. Narbonne and Patricia Vickers-Rich, 2008."
                },
                new Book
                {
                    Title = "SpaceShipOne: An Illustrated History",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2008,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Dan Linehan, 2008."
                },
                new Book
                {
                    Title = "From the Pen of Paul: The Fantastic Images of Frank R. Paul",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2009,
                    Type = BookType.Forward,
                    Description = "Wrote Preface. Stephen D. Korshak, 2009."
                },
                new Book
                {
                    Title = "The Story of Astronomy",
                    Author = "Arthur C. Clarke",
                    PublicationYear = 2012,
                    Type = BookType.Forward,
                    Description = "Wrote Foreword. Heather Couper and Nigel Henbest, 2012."
                },
                new Book
                {
                    Title = "Marooned off Vesta",
                    Author = "Isaac Asimov",
                    PublicationYear = 1939,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in March, 1939.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "The Weapon Too Dreadful to Use",
                    Author = "Isaac Asimov",
                    PublicationYear = 1939,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in May, 1939.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Trends",
                    Author = "Isaac Asimov",
                    PublicationYear = 1939,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in July, 1939.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Half-Breed",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Astonishing Stories in February, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Ring Around the Sun",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Future Fiction in March, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Callistan Menace",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astonishing Stories in April, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Magnificent Possession",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Future Fiction in July, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Robbie",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Strange Playfellow'. First published in Super Science Stories in September, 1940. Published separately by Creative Education in 1989. Won 1941 Retro Hugo Award for Best Short Story.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Homo Sol", 
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in September, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Half-Breeds on Venus",
                    Author = "Isaac Asimov",
                    PublicationYear = 1940,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Astonishing Stories in December, 1940.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "History",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Super Science Stories in March, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Secret Sense",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Cosmic Stories in March, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Heredity",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astonishing Stories in April, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Reason",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in I, Robot in April, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Liar!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in April, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Nightfall",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in September, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Super-Neutron",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astonishing Stories in September, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Not Final!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1941,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in October, 1941.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Christmas on Ganymede",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Startling Stories in January, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Robot AL-76 Goes Astray",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in February, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" }
                    }
                },
                new Book
                {
                    Title = "Runaround",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in February, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Black Friar of the Flame",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Planet Stories in Spring, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Time Pussy",
                    Author = "Isaac Asimov",
                    WrittenAs = "George E. Dale",
                    PublicationYear = 1942,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in April, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Foundation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "Titled 'The Encyclopedists' in the 'Foundation' novel. First published in Astounding Science Fiction in May, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation" },
                        new Tag { Name = "Adapted for Screen" }
                    }
                },
                new Book
                {
                    Title = "The Weapon",
                    Author = "Isaac Asimov",
                    WrittenAs = "H. B. Ogden",
                    PublicationYear = 1942,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "In 'The Early Asimov', he listed this as one of his lost early stories, forgetting it had been published under a pseudonym in Super Science Stories in May, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: In Memory Yet Green" }
                    }
                },
                new Book
                {
                    Title = "Bridle and Saddle",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Mayors'. First published in Astounding Science Fiction in June, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation" }
                    }
                },
                new Book
                {
                    Title = "Victory Unintentional",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Super Science Stories in August, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" }
                    }
                },
                new Book
                {
                    Title = "The Hazing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Thrilling Wonder Stories in October, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Imaginary",
                    Author = "Isaac Asimov",
                    PublicationYear = 1942,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Super Science Stories in November, 1942.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Death Sentence",
                    Author = "Isaac Asimov",
                    PublicationYear = 1943,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in November, 1943.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Catch That Rabbit",
                    Author = "Isaac Asimov",
                    PublicationYear = 1944,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in February, 1944.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "The Big and the Little",
                    Author = "Isaac Asimov",
                    PublicationYear = 1944,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Merchant Princes'. First published in Astounding Science Fiction in August, 1944.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation" }
                    }
                },
                new Book
                {
                    Title = "The Wedge",
                    Author = "Isaac Asimov",
                    PublicationYear = 1944,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in October, 1944.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation" }
                    }
                },
                new Book
                {
                    Title = "Blind Alley",
                    Author = "Isaac Asimov",
                    PublicationYear = 1945,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in March, 1945.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Galactic Empire" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Dead Hand",
                    Author = "Isaac Asimov",
                    PublicationYear = 1945,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The General'. First published in Astounding Science Fiction in April, 1945.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation and Empire" }
                    }
                },
                new Book
                {
                    Title = "Escape!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1945,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Paradoxical Escape'. First published in Astounding Science Fiction in August, 1945.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                    }
                },
                new Book
                {
                    Title = "The Mule",
                    Author = "Isaac Asimov",
                    PublicationYear = 1945,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Mule's Children'. First published in Astounding Science Fiction in November and December, 1945.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation and Empire" }
                    }
                },
                new Book
                {
                    Title = "Evidence",
                    Author = "Isaac Asimov",
                    PublicationYear = 1946,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in September, 1946.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Little Lost Robot",
                    Author = "Isaac Asimov",
                    PublicationYear = 1947,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in March, 1947. Made into an episode of 'Out of This World' in 1962. Part of the BBC Radio Drama 'I, Robot'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Now You See It—",
                    Author = "Isaac Asimov",
                    PublicationYear = 1948,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Search by the Mule'. First published in Astounding Science Fiction in January, 1948.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Second Foundation" }
                    }
                },
                new Book
                {
                    Title = "The Endochronic Properties of Resublimated Thiotimoline",
                    Author = "Isaac Asimov",
                    PublicationYear = 1948,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in March, 1948.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Only a Trillion" },
                        new Tag { Name = "Collection: The Early Asimov" },
                        
                    }
                },
                new Book
                {
                    Title = "No Connection",
                    Author = "Isaac Asimov",
                    PublicationYear = 1948,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in June, 1948.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "The Red Queen's Race",
                    Author = "Isaac Asimov",
                    PublicationYear = 1949,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in January, 1949.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Mother Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1949,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in May, 1949.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Early Asimov" },
                    }
                },
                new Book
                {
                    Title = "—And Now You Don't",
                    Author = "Isaac Asimov",
                    PublicationYear = 1949,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Search by the Foundation'. First published in Astounding Science Fiction in November, 1949.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Second Foundation" }
                    }
                },
                new Book
                {
                    Title = "The Little Man on the Subway",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "With Frederik Pohl. First published in Fantasy Book in January, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Evitable Conflict",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in June, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: I, Robot" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Legal Rites",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "With Frederik Pohl. First published in Weird Tales in September, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" }
                    }
                },
                new Book
                {
                    Title = "Darwinian Pool Room",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in October, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Green Patches",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Misbegotten Missionary'. First published in Galaxy Science Fiction in November, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Day of the Hunters",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Future Combined With Science Fiction Stories in November, 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Satisfaction Guaranteed",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in April, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Hostess",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in May, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Breeds There a Man...?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in June, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Through a Glass, Clearly" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Psychohistorians",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    Type = BookType.ShortStory,
                    Description = "First published in the Foundation novel (Gnome Press, 1951).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" },
                        new Tag { Name = "Collection: Foundation" }
                    }
                },
                new Book
                {
                    Title = "In a Good Cause—",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in New Tales of Space and Time (Henry Holt & Co., 1951).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "C-Chute",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in October, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Collection: Through a Glass, Clearly" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Shah Guido G.",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Marvel in November, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                    }
                },
                new Book
                {
                    Title = "The Fun They Had",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' and Girls' Page in December, 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Youth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Space Science Fiction in May, 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Martian Way and Other Stories" },
                    }
                },
                new Book
                {
                    Title = "What If—",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Fantastic in June, 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Martian Way",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in November, 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Martian Way and Other Stories" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Deep",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in December, 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Martian Way and Other Stories" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Button, Button",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Startling Stories in January, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Monkey's Finger",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Startling Stories in February, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Nobody Here But—",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Star Science Fiction Stories in February, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Sally",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Fantastic in May, 1953. Published separately by Creative Education in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Flies",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in June, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Kid Stuff",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Beyond Fantasy Fiction in September, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Belief",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in October, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Through a Glass, Clearly" },
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                    }
                },
                new Book
                {
                    Title = "The Micropsychiatric Applications of Thiotimoline",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in December, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Only a Trillion" },
                    }
                },
                new Book
                {
                    Title = "Everest",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Universe Science Fiction in December, 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Sucker Bait",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in February, 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Martian Way and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Pause",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in April, 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Immortal Bard",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Universe Science Fiction in May, 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Foundation of S.F. Success",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    PublicationMonth = 10,
                    Type = BookType.Poem,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Let's Not",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Boston University Graduate Journal in December, 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "It's Such a Beautiful Day",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Star Science Fiction Stories No.3 in January, 1955. Published separately by Creative Education in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Through a Glass, Clearly" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Singing Bell",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in January, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Question",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Computers and Automation in March, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" }
                    }
                },
                new Book
                {
                    Title = "Risk",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in May, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" }
                    }
                },
                new Book
                {
                    Title = "The Last Trump",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Fantastic Universe in June, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Franchise",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in August, 1955. Published separately by Creative Education in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Talking Stone",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in October, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Portable Star",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    Type = BookType.ShortStory,
                    Description = "First published in Thrilling Wonder Stories in Winter, 1955."
                },
                new Book
                {
                    Title = "Dreamworld",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in November, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Opus 100" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                    }
                },
                new Book
                {
                    Title = "Dreaming Is a Private Thing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in December, 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Message",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in February, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Dead Past",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in April, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Hell-Fire",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Fantastic Universe in May, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Living Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in The Original Science Fiction Stories in May, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "What's in a Name?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Death of a Honey-Blonde'. First published in The Saint Detective Magazine in June, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                    }
                },
                new Book
                {
                    Title = "The Dying Night",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in July, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Someday",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Infinity Science Fiction in August, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Each an Explorer",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Future #30 in August, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Pâté de Foie Gras",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in September, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: Only a Trillion" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Watery Place",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Satellite Science Fiction in October, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "First Law",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Fantastic Universe in October, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" },
                    }
                },
                new Book
                {
                    Title = "Gimmicks Three",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in November, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Last Question",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Science Fiction Quarterly in November, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: Opus 100" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Jokester",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in December, 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Strikebreaker",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in the January, 1957 issue of 'The Original Science Fiction Stories' as 'Male Stikebreaker'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Dust of Death",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Venture Science Fiction in January, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Let's Get Together",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Infinity Science Fiction in February, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Author's Ordeal",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 5,
                    Type = BookType.Poem,
                    Description = "First published in Science Fiction Quarterly in May, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Earth Is Room Enough" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Blank!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Infinity Science Fiction in June, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Does a Bee Care?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in June, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" }
                    }
                },
                new Book
                {
                    Title = "A Woman's Heart",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Satellite in June, 1957."
                },
                new Book
                {
                    Title = "Profession",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in July, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "A Loint of Paw",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in August, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Ideas Die Hard",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in October, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "I'm in Marsport Without Hilda",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Venture Science Fiction in November, 1957. Sometimes bowdlerized, as in Nine Tomorrows.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Insert Knob A in Hole B",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in December, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Galley Slave",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in December, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Gentle Vultures",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Super-Science Fiction in December, 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Spell My Name with an S",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'S, as in Zebatinsky'. First published in Star Science Fiction in January, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Lenny",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Infinity Science Fiction in January, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "I Just Make Them Up, See!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 2,
                    Type = BookType.Poem,
                    Description = "First published in Nine Tomorrows in February, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Feeling of Power",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in February, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "Silly Asses",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Future Science Fiction in February, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "All the Troubles of the World",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Super-Science Fiction in April, 1958. Published separately by Creative Education in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Buy Jupiter",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Venture Science Fiction in May, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Up-to-Date Sorcerer",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in July, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Ugly Little Boy (Short Story)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Lastborn'. First published in Galaxy Science Fiction in September, 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "A Statue for Father",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Satellite Science Fiction in February, 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Anniversary",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Science Fiction Stories in March, 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Unto the Fourth Generation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in April, 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Obituary",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in August, 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Rain, Rain, Go Away",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding Science Fiction in September, 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Rejection Slips",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 9,
                    Type = BookType.Poem,
                    Description = "First published in Nine Tomorrows in 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nine Tomorrows" },
                        new Tag { Name = "Collection: Science Fiction by Asimov" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Covenant",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "Asimov wrote part two of this five-part round-robin story. First published in Fantastic Story Magazine in October, 1959."
                },
                new Book
                {
                    Title = "Thiotimoline and the Space Age",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction and Fact in October, 1960.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Opus 100" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "What Is This Thing Called Love?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1961,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Playboy and the Slime God'. First published in Amazing Stories in March, 1961.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "The Machine That Won the War",
                    Author = "Isaac Asimov",
                    PublicationYear = 1961,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1961.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "My Son, the Physicist",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Scientific American in February, 1962.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Star Light",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Scientific American in October, 1962.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Author! Author!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "Written in 1943. First published in The Unknown Five in January, 1964.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Eyes Do More Than See",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in April, 1965.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: Science Fiction by Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Founding Father",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Galaxy Science Fiction in October, 1965.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Man Who Made the 21st Century",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in October, 1965."
                },
                new Book
                {
                    Title = "The Key",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1966.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Prime of Life",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    PublicationMonth = 10,
                    Type = BookType.Poem,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1966.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Billiard Ball",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in March, 1967.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Asimov's Mysteries" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Segregationist",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.ShortStory,
                    Description = "First published in Abbottempo, book 4, 1967.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Nightfall and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 1" }
                    }
                },
                new Book
                {
                    Title = "Exile to Hell",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction and Fact in May, 1968.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Key Item",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Computer That Went on Strike'. First published in The Magazine of Fantasy and Science Fiction in July, 1968.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Proper Study",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in September, 1968.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                    }
                },
                new Book
                {
                    Title = "The Holmes-Ginsbook Device",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in December, 1968.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Opus 100" },
                    }
                },
                new Book
                {
                    Title = "Feminine Intuition",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1969.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Waterclap",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in April, 1970.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                    }
                },
                new Book
                {
                    Title = "A Problem of Numbers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'As Chemist to Chemist'. First published in Ellery Queen's Mystery Magazine in May, 1970.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                    }
                },
                new Book
                {
                    Title = "2430 A.D.",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in IBM Magazine in October, 1970.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                    }
                },
                new Book
                {
                    Title = "The Best New Thing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.ShortStory,
                    Description = "First published in The Best New Thing (World Publishing Co., 1971).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Best New Thing" },
                    }
                },
                new Book
                {
                    Title = "The Greatest Asset",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction and Fact in January, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Acquisitive Chuckle",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in January, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Mirror Image",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction and Fact in May, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Best of Isaac Asimov" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Ph as in Phony",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Phony PhD'. First published in Ellery Queen's Mystery Magazine in July, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Truth to Tell",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Man Who Never Told a Lie'. First published in Ellery Queen's Mystery Magazine in October, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Go, Little Book!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Matchbook Collector'. First published in Ellery Queen's Mystery Magazine in December, 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Take a Match",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.ShortStory,
                    Description = "First published in New Dimensions II (Doubleday, 1972).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Thiotimoline to the Stars",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.ShortStory,
                    Description = "First published in Astounding: John W. Campbell Memorial Anthology (Random House, 1973).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Early Sunday Morning",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Biological Clock'. First published in Ellery Queen's Mystery Magazine in March, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Obvious Factor",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Pointing Finger",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in July, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Miss What?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Warning to Miss Earth'. First published in Ellery Queen's Mystery Magazine in September, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Light Verse",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.ShortStory,
                    Description = "First published in The Saturday Evening Post in September-October, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Buy Jupiter and Other Stories" },
                        new Tag { Name = "Collection: Opus 200" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Out of Sight",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Six Suspects'. First published in Ellery Queen's Mystery Magazine in December, 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Yankee Doodle Went to Town",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.ShortStory,
                    Description = "First published in Tales of the Black Widowers (Doubleday, 1974).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Lullaby of Broadway",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.ShortStory,
                    Description = "First published in Tales of the Black Widowers (Doubleday, 1974).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Curious Omission",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.ShortStory,
                    Description = "First published in Tales of the Black Widowers (Doubleday, 1974).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Dream",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in The Saturday Evening Post in January, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Opus 200" }
                    }
                },
                new Book
                {
                    Title = "When No Man Pursueth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Benjamin's Dream",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Second Dream'. First published in The Saturday Evening Post in April, 1974."
                },
                new Book
                {
                    Title = "Party by Satellite",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Third Dream'. First published in The Saturday Evening Post in May, 1974."
                },
                new Book
                {
                    Title = "Quicker Than the Eye",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = ". . . That Thou Art Mindful of Him",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in May, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Stranger in Paradise",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in If: Worlds of Science Fiction in May, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Benjamin's Bicentennial Blast",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Fourth Dream'. First published in The Saturday Evening Post in June, 1974."
                },
                new Book
                {
                    Title = "The Iron Gem",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in July, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Half-Baked Publisher's Delight",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Three Numbers'. Co-written with Jeffrey S. Hudson. First published in The Best from If, Volume III.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best from If, Volume III" },
                        new Tag { Name = "Collection: 100 Great Science Fiction Short Short Stories" }
                    }
                },
                new Book
                {
                    Title = "Nothing Like Murder",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in October, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "No Smoking",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Confessions of an American Cigarette Smoker'. First published in Ellery Queen's Mystery Magazine in December, 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Heavenly Host (Short Story)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in December, 1974. Later published as an extended version by itself."
                },
                new Book
                {
                    Title = "Big Game",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.ShortStory,
                    Description = "Written in 1941. Asimov listed this as a lost story in 1972's The Early Asimov. It was later found and published in the collection Before the Golden Age (Doubleday, 1974).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Before the Golden Age" }
                    }
                },
                new Book
                {
                    Title = "The Life and Times of Multivac",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in The New York Times in January, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Sarah Tops",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Try Sarah Tops'. First published in Boys' Life in February, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "A Boy's Best Friend",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in March, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Complete Robot" }
                    }
                },
                new Book
                {
                    Title = "The One and Only East",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Little Things",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Point of View",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in July, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Complete Robot" }
                    }
                },
                new Book
                {
                    Title = "Earthset and Evening Star",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in August, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" },
                        new Tag { Name = "Collection: Opus 200" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "About Nothing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.ShortStory,
                    Description = "First appeared on a postcard, subsequently published in Science Fiction Review, August 1975 and then Isaac Asimov's Science Fiction Magazine, Summer 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Opus 300" }
                    }
                },
                new Book
                {
                    Title = "Halloween",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in American Way in October, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "A Case of Need",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Young World Magazine in October, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Santa Claus Gets a Coin",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in December, 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Friday the Thirteenth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy and Science Fiction in January, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Season's Greetings!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.ShortStory,
                    Description = "First published in More Tales of the Black Widowers (Doubleday, 1976).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Unabridged",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.ShortStory,
                    Description = "First published in More Tales of the Black Widowers (Doubleday, 1976).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Ultimate Crime",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.ShortStory,
                    Description = "First published in More Tales of the Black Widowers (Doubleday, 1976).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: More Tales of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Bicentennial Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Stellar #2 (Ballantine Books, February 1976), made into a Hollywood movie in 1999 starring Robin Williams.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Robot Visions" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: Opus 200" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Asimov Chronicles" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Winnowing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction and Fact in February, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Old-Fashioned",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Bell Telephone Magazine in January-February, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Marching In",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in High Fidelity in May, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "Birth of a Notion",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Amazing Stories in June, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Cross of Lorraine",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Tercentenary Incident",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in August, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Bicentennial Man and Other Stories" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: The Complete Stories, Volume 2" }
                    }
                },
                new Book
                {
                    Title = "The Family Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in November, 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Good Taste (Short Story)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.ShortStory,
                    Description = "First published in Good Taste (Apocalypse Press, 1976) (limited edition).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Opus 200" },
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "To Tell at a Glance",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "First published in The Saturday Evening Post in February, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "True Love",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in American Way in February, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: 3 by Asimov" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Think!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in Spring, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Complete Robot" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "The Sports Page",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in April, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Sure Thing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in Summer, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: Opus 300" }
                    }
                },
                new Book
                {
                    Title = "The Thirteenth Day of Christmas",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in July, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: Opus 200" }
                    }
                },
                new Book
                {
                    Title = "The Missing Item",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in Winter, 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Key Word",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.ShortStory,
                    Description = "First published in The Key Word and Other Mysteries (Walker & Company, 1977).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Next Day",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Disappearing Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in June, 1978. Appears in the British edition of The Key Word and Other Mysteries (Walker & Company, 1978).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Key Word and Other Mysteries" },
                        new Tag { Name = "Collection: The Disappearing Man and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Found!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.ShortStory,
                    Description = "First published in Omni in October, 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Fair Exchange?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.ShortStory,
                    Description = "First published in Asimov's SF Adventure Magazine in Fall, 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: 3 by Asimov" },
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Strike!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Omni in January, 1979."
                },
                new Book
                {
                    Title = "Nothing for Nothing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in February, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Irrelevance!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Matter of Irrelevance'. First published in Ellery Queen's Mystery Magazine in March, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "How It Happened",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Asimov's SF Adventure Magazine in Spring, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: Opus 300" }
                    }
                },
                new Book
                {
                    Title = "None So Blind",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "To the Barest",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in August, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Backward Look",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in September, 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "It Is Coming",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.ShortStory,
                    Description = "First published in Various newspapers, 1979 (advert for Field Enterprises).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "The Last Answer",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction / Science Fact in January, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: 3 by Asimov" },
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Second Best",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Casebook of the Black Widowers (Doubleday, January 1980).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Middle Name",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Casebook of the Black Widowers (Doubleday, January 1980).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "What Time Is It?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Casebook of the Black Widowers (Doubleday, January 1980).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Casebook of the Black Widowers" },
                        new Tag { Name = "Collection: Opus 300" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "For the Birds",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in May, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Sixty Million Trillion Combinations",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Banquets of the Black Widowers in May, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Woman in the Bar",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Getting Even",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Gallery in August, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: Tales from the Spaceport Bar" }
                    }
                },
                new Book
                {
                    Title = "No Refuge Could Save",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'To Spot a Spy'. First published in Gallery in September, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Good Samaritan",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in September, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                    }
                },
                new Book
                {
                    Title = "Death of a Foy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in October, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Opus 300" },
                        new Tag { Name = "Collection: The Best Science Fiction of Isaac Asimov" },
                        new Tag { Name = "Collection: Science Fiction by Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Telephone Number",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Winning Number'. First published in Gallery in October, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Men Who Wouldn't Talk",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Pigeon English'. First published in Gallery in November, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "A Clear Shot",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Big Shot'. First published in Gallery in December, 1980.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Year of the Action",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Gilbert and Sullivan Mystery'. First published in Ellery Queen's Mystery Magazine in January, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Irresistible to Women",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Call Me Irresistible'. First published in Gallery in January, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "He Wasn't There",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Spy Who Was Out-of-Focus'. First published in Gallery in February, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Thin Line",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Taxicab Crackdown'. First published in Gallery in March, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Mystery Tune",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Death Song'. First published in Gallery in April, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Last Shuttle",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Today (a Florida newspaper supplement) in April, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" }
                    }
                },
                new Book
                {
                    Title = "Hide and Seek",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Gallery in May, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Gift",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Decipher Deception'. First published in Gallery in June, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Can You Prove It?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Hot or Cold",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Gallery in July, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Thirteenth Page",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Gallery in August, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "1 to 999",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'One in a Thousand'. First published in Gallery in September, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: Opus 300" }
                    }
                },
                new Book
                {
                    Title = "Twelve Years Old",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The 12-Year-Old Problem'. First published in Gallery in October, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "A Perfect Fit",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in EDN in October, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Opus 300" }
                    }
                },
                new Book
                {
                    Title = "Testing, Testing!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Cloak and Dagger Duel'. First published in Gallery in November, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Appleby Story",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Last Laugh'. First published in Gallery in December, 1981.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Ignition Point!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.ShortStory,
                    Description = "First published in Finding the Right Speaker (American Society of Association Executives, 1981).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Dollars and Cents",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Countdown to Disaster'. First published in Gallery in January, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "Friends and Allies",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Mirror Image'. First published in Gallery in February, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Lest We Remember",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in February, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Robot Dreams" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Which Is Which?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Perfect Alibi'. First published in Gallery in March, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Winds of Change",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Speculations (Hougton Mifflin, April, 1982).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: The Edge of Tomorrow" }
                    }
                },
                new Book
                {
                    Title = "One Night of Song",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy & Science Fiction in April, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Sign",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Telltale Sign'. First published in Gallery in April, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Phoenician Bauble",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Catching the Fox",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Stopping the Fox'. First published in Gallery in May, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Getting the Combination",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Playing It by the Numbers'. First published in Gallery in June, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "To the Victor",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in July, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Library Book",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Mystery Book'. First published in Gallery in July, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" },
                        new Tag { Name = "Collection: Opus 300" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Three Goblets",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Flash of Brilliance'. First published in Gallery in August, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Spell It!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Book Smart'. First published in Gallery in September, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Lucky Seven",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in September, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Disappearing Man and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Dim Rumble",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in October, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Science Fiction by Asimov" },
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Two Women",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Cherchez la Femme: the Case of the Disappearing Woman'. First published in Gallery in October, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Super Runner",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Runner's World in October, 1982."
                },
                new Book
                {
                    Title = "The Smile That Loses",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in The Magazine of Fantasy & Science Fiction in November, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Winds of Change and Other Stories" },
                        new Tag { Name = "Collection: Opus 300" },
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Sending a Signal",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Piece of the Rock'. First published in Gallery in November, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Half a Ghost",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Ghost of a Chance'. First published in Gallery in December, 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "There Was a Young Lady",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Poetic License'. First published in Gallery in January, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Potential",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in February, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Multivac" },
                        new Tag { Name = "Collection: Science Fiction by Asimov" },
                    }
                },
                new Book
                {
                    Title = "State Capital",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'A Chemical Solution'. First published in Gallery in February, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Never Out of Sight",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Amusement Lark'. First published in Gallery in March, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Favourite Piece",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Face the Music'. First published in Gallery in April, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Union Club Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Magic Umbrella",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Stormy Weather'. First published in Gallery in May, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "A Monday in April",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Briefcase in the Taxi",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Circuit Breaker'. First published in Gallery in June, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Bird That Sang Bass",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Riddled With Clues'. First published in Gallery in July, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Last Caesar",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'Great Caesar's Ghost'. First published in Gallery in August, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Saving Humanity",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in September, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Nothing Might Happen",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Alfred Hitchcock's Mystery Magazine in December, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Speck",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Gallery in December, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Christmas Solution",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in December, 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Disappearing Man and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "A Matter of Principle",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in February, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Neither Brute nor Human",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in April, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "The Evil Drink Does",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in May, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Writing Time",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in July, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Triply Unique",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in July, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Intrusion",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Banquets of the Black Widowers in September, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Driver",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Banquets of the Black Widowers in September, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Wrong House",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Banquets of the Black Widowers in September, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Redhead",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in October, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Banquets of the Black Widowers" },
                        new Tag { Name = "Collection: The Best Mysteries of Isaac Asimov" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Ten-Second Election",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Omni in November, 1984."
                },
                new Book
                {
                    Title = "Dashing Through the Snow",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Science Fiction by Asimov in December, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" },
                        new Tag { Name = "Collection: Science Fiction by Asimov" }
                    }
                },
                new Book
                {
                    Title = "The Year of the Feast",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in December, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Queen and King",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Espionage in December, 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Hallucination",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in February, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Fourth Homonym",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Upside Down",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Unique Is Where You Find It",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in The Edge of Tomorrow in July, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Edge of Tomorrow" },
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Triple Devil",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in August, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" },
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Logic Is Logic",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in August, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Suspect",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. 'The Taunter'. First published in Ellery Queen's Mystery Magazine in October, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "He Travels the Fastest",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in November, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Straight Lines",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in December, 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Twins",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.ShortStory,
                    Description = "First published in The Disappearing Man and Other Mysteries (Walker & Company, 1985).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Disappearing Man and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "The Man in the Park",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.ShortStory,
                    Description = "First published in The Disappearing Man and Other Mysteries (Walker & Company, 1985).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Disappearing Man and Other Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Feghoot and the Courts",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.ShortStory,
                    Description = "First published in Bred Any Good Rooks Lately? (Doubleday, 1986).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Eye of the Beholder",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Azazel in January, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Child's Play",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in January, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "New England Equinox",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "More Things in Heaven and Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.ShortStory,
                    Description = "First published in Science Fiction by Asimov (Davis Publications, 1986).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Science Fiction by Asimov" },
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Sunset on the Water",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" },
                    }
                },
                new Book
                {
                    Title = "Ten",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in August, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Zip Code",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Boys' Life in September, 1986."
                },
                new Book
                {
                    Title = "Where Is He?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in October, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Mind's Construction",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Azazel in October, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "Robot Dreams",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Robot Dreams (Berkley Books, November 1986).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Robot Dreams" }
                    }
                },
                new Book
                {
                    Title = "The Common Name",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in December, 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Left to Right",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction / Science Fact in January, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Fights of Spring",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 2,
                    Type = BookType.ShortStory,
                    Description = "First published in Azazel in February, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Old Purse",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Teddy Bear",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in May, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Stamp",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Left to Right, and Beyond",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "Left to Right, and Beyond, with an alternative ending by Harrison Roth. First published in Analog Science Fiction / Science Fact in July, 1987."
                },
                new Book
                {
                    Title = "Galatea",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published Isaac Asimov's Science Fiction Magazine in mid-December, 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Fable of the Three Princes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Spaceships and Spells (Harper & Row, 1987).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "The Two-Centimeter Demon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Azazel in January, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Quiet Place",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" },
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "The Legacy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in April, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Turning Point",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in The Drabble Project in April, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Drabble Project" }
                    }
                },
                new Book
                {
                    Title = "Flight of Fancy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Azazel in May, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Azazel" }
                    }
                },
                new Book
                {
                    Title = "The Lost Dog",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: Mysterious Menagerie" }
                    }
                },
                new Book
                {
                    Title = "The Smile of the Chipper",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "Supplement to Bloomberg Businessweek, 21 October 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "I Love Little Pussy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in November, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Asimov Chronicles" }
                    }
                },
                new Book
                {
                    Title = "Christmas Without Rodney",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in December, 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "The Instability",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in The Observer in January, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Good-bye to Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Interview Magazine in January, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Last Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "The Envelope",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in April, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Alexander the God",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Columbia in June, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Northwestward",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in The Further Adventures of Batman (Bantam Books, July 1989).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" },
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "The Mad Scientist",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction / Science Fact in July, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "To Your Health",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in August, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "The Alibi",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in September, 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Ho! Ho! Ho!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Mistletoe Mysteries: Tales of Yuletide Murder (Mysterious Press, October 1989).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" },
                        new Tag { Name = "Collection: Mistletoe Mysteries" }
                    }
                },
                new Book
                {
                    Title = "Too Bad!",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in The Microverse (Bantam, November 1989).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "The Lucky Piece",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Puzzles of the Black Widowers (Doubleday, January 1990).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Four-Leaf Clover",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Puzzles of the Black Widowers (Doubleday, January 1990).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Recipe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Puzzles of the Black Widowers (Doubleday, January 1990).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Puzzles of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Yes, but Why?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    Type = BookType.ShortStory,
                    Description = "First published in The Armchair Detective, Spring 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Lost in a Space Warp",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Robot Visions (Short Story)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Robot Visions (Roc Books, April 1990).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Robot Visions" }
                    }
                },
                new Book
                {
                    Title = "Fault-Intolerant",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in May, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Police at the Door",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in June, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "In the Canyon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Omni in July, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Wine Is a Mocker",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in July, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "Cal",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 1,
                    Type = BookType.ShortStory,
                    Description = "First published in Cal (Doubleday, 1990) (limited edition pamphlet).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Haunted Cabin",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 10,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in October, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "The Time Traveller",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in November, 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "Kid Brother",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in mid-December 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Missing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in March, 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Baby, It's Cold Outside",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in June, 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "The Guest's Guest",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "First published in Ellery Queen's Mystery Magazine in August, 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Return of the Black Widowers" }
                    }
                },
                new Book
                {
                    Title = "Gold",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 9,
                    Type = BookType.ShortStory,
                    Description = "First published in Analog Science Fiction / Science Fact in September, 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Frustration",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in There Won't Be War (Tor Books, November 1991).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Prince Delightful and the Flameless Dragon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Once Upon a Time: A Treasury of Modern Fairy Tales (Del Rey / Ballantine Books, November 1991).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "It's a Job",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    PublicationMonth = 12,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in December, 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "The Critic on the Hearth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in November, 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "March Against the Foe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1994,
                    PublicationMonth = 4,
                    Type = BookType.ShortStory,
                    Description = "First published in Isaac Asimov's Science Fiction Magazine in April, 1994.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Magic" }
                    }
                },
                new Book
                {
                    Title = "Battle-Hymn",
                    Author = "Isaac Asimov",
                    PublicationYear = 1995,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Gold (HarperPrism, March 1995).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "The Nations in Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1995,
                    PublicationMonth = 3,
                    Type = BookType.ShortStory,
                    Description = "First published in Gold (HarperPrism, March 1995).",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Gold" }
                    }
                },
                new Book
                {
                    Title = "Pebble in the Sky",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1950.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Galactic Empire" },
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "I, Robot",
                    Author = "Isaac Asimov",
                    PublicationYear = 1950,
                    PublicationMonth = 12,
                    Type = BookType.Novel,
                    Description = "First published by Gnome Press in 1950. Fixup novel of nine robot short stories, with a frame of a reporter interviewing an elderly Dr. Susan Calvin. All of the stories, minues the framing, were includinded in 'The Complete Robot'. Will Smith movie really not related in plot, but actually does fit fairly well with the stories here.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: I, Robot" }
                    }
                },
                new Book
                {
                    Title = "The Stars, Like Dust",
                    Author = "Isaac Asimov",
                    PublicationYear = 1951,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1951.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Galactic Empire" }
                    }
                },
                new Book
                {
                    Title = "David Starr, Space Ranger",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Foundation and Empire",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "First published by Gnome Press in 1952."
                },
                new Book
                {
                    Title = "The Currents of Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1952.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Galactic Empire" }
                    }
                },
                new Book
                {
                    Title = "Biochemistry and Human Metabolism",
                    Author = "Isaac Asimov",
                    PublicationYear = 1952,
                    Type = BookType.NonFiction,
                    Description = "First published by Williams & Wilkins in 1952."
                },
                new Book
                {
                    Title = "Second Foundation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    Type = BookType.Novel,
                    Description = "First published by Gnome Press in 1953."
                },
                new Book
                {
                    Title = "Lucky Starr and the Pirates of the Asteroids",
                    Author = "Isaac Asimov",
                    PublicationYear = 1953,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1953.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Caves of Steel",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" }
                    }
                },
                new Book
                {
                    Title = "Lucky Starr and the Oceans of Venus",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1954.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Chemicals of Life: Enzymes, Vitamins, and Hormones",
                    Author = "Isaac Asimov",
                    PublicationYear = 1954,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1954."
                },
                new Book
                {
                    Title = "The End of Eternity",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1955.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "The Martian Way and Other Stories",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1955."
                },
                new Book
                {
                    Title = "Races and People",
                    Author = "Isaac Asimov",
                    PublicationYear = 1955,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1955, co-written with William C. Boyd, illustrations by John Bradford"
                },
                new Book
                {
                    Title = "Lucky Starr and the Big Sun of Mercury",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1956.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Chemistry and Human Health",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    Type = BookType.NonFiction,
                    Description = "First published by McGraw-Hill in 1956."
                },
                new Book
                {
                    Title = "Inside the Atom",
                    Author = "Isaac Asimov",
                    PublicationYear = 1956,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1956."
                },
                new Book
                {
                    Title = "The Naked Sun",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Collection: The Rest of the Robots" }
                    }
                },
                new Book
                {
                    Title = "Lucky Starr and the Moons of Jupiter",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1957.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Building Blocks of the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1957."
                },
                new Book
                {
                    Title = "Earth Is Room Enough: Science Fiction: Tales of Our Own Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1957."
                },
                new Book
                {
                    Title = "Only a Trillion",
                    Author = "Isaac Asimov",
                    PublicationYear = 1957,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1957."
                },
                new Book
                {
                    Title = "The World of Carbon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1958."
                },
                new Book
                {
                    Title = "Lucky Starr and the Rings of Saturn",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1958.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The World of Nitrogen",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1958."
                },
                new Book
                {
                    Title = "The Death Dealers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1958,
                    Type = BookType.Novel,
                    Description = "First published by Avon in 1958. Republished as A Whiff of Death in 1979."
                },
                new Book
                {
                    Title = "Nine Tomorrows: Tales of the Near Future",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1959."
                },
                new Book
                {
                    Title = "The Clock We Live On",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1959."
                },
                new Book
                {
                    Title = "Words of Science, and the History Behind Them",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1959.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Realm of Numbers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1959."
                },
                new Book
                {
                    Title = "Breakthroughs in Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1959,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1959."
                },
                new Book
                {
                    Title = "The Living River",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1960."
                },
                new Book
                {
                    Title = "The Kingdom of the Sun",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1960."
                },
                new Book
                {
                    Title = "Realm of Measure",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1960."
                },
                new Book
                {
                    Title = "Satellites in Outer Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Random House in 1960."
                },
                new Book
                {
                    Title = "The Wellsprings of Life",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1960."
                },
                new Book
                {
                    Title = "The Intelligent Man's Guide to Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Basic Books in 1960."
                },
                new Book
                {
                    Title = "The New Intelligent Man's Guide to Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "Second edition of the Intelligent Man's Guide to Science, published by Basic Books in 1965."
                },
                new Book
                {
                    Title = "Asimov's Guide to Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "Third edition of the Intelligent Man's Guide to Science, published by Basic Books in 1972."
                },
                new Book
                {
                    Title = "Asimov's New Guide to Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "Fourth edition of the Intelligent Man's Guide to Science, published by Basic Books in 1984."
                },
                new Book
                {
                    Title = "The Double Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1960,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1960."
                },
                new Book
                {
                    Title = "Realm of Algebra",
                    Author = "Isaac Asimov",
                    PublicationYear = 1961,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1961."
                },
                new Book
                {
                    Title = "Words from the Myths",
                    Author = "Isaac Asimov",
                    PublicationYear = 1961,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1961.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Life and Energy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1962."
                },
                new Book
                {
                    Title = "Words in Genesis",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1962. Illustrations by William Barss.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Fact and Fancy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1962."
                },
                new Book
                {
                    Title = "Words on the Map",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1962.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Search for the Elements",
                    Author = "Isaac Asimov",
                    PublicationYear = 1962,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1962."
                },
                new Book
                {
                    Title = "Words from the Exodus",
                    Author = "Isaac Asimov",
                    PublicationYear = 1963,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1963.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Genetic Code",
                    Author = "Isaac Asimov",
                    PublicationYear = 1963,
                    Type = BookType.NonFiction,
                    Description = "First published by Orion Press in 1963."
                },
                new Book
                {
                    Title = "The Human Body: Its Structure and Operation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1963,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1963. Illustrations by Anthony Ravielli. Revised/expanded edition, 1992."
                },
                new Book
                {
                    Title = "View from a Height",
                    Author = "Isaac Asimov",
                    PublicationYear = 1963,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1963."
                },
                new Book
                {
                    Title = "The Kite That Won the Revolution",
                    Author = "Isaac Asimov",
                    PublicationYear = 1963,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1963."
                },
                new Book
                {
                    Title = "The Human Brain: Its Capacities and Functions",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1964."
                },
                new Book
                {
                    Title = "A Short History of Biology",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "First published by Natural History Press in 1964."
                },
                new Book
                {
                    Title = "Quick and Easy Math",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1964."
                },
                new Book
                {
                    Title = "Adding a Dimension",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1964. With Stephen H. Dole."
                },
                new Book
                {
                    Title = "The Rest of the Robots",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1964."
                },
                new Book
                {
                    Title = "Asimov's Biographical Encyclopedia of Science and Technology",
                    Author = "Isaac Asimov",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1964. 2nd edition, 1972. 3rd edition, 1983."
                },
                new Book
                {
                    Title = "A Short History of Chemistry",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1965."
                },
                new Book
                {
                    Title = "The Greeks: A Great Adventure",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1965.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Of Time and Space and Other Things",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1965."
                },
                new Book
                {
                    Title = "An Easy Introduction to the Slide Rule",
                    Author = "Isaac Asimov",
                    PublicationYear = 1965,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1965."
                },
                new Book
                {
                    Title = "Fantastic Voyage",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.Novel,
                    Description = "First published by Houghton Mifflin in 1966."
                },
                new Book
                {
                    Title = "The Noble Gases",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Basic Books in 1966."
                },
                new Book
                {
                    Title = "The Neutrino: Ghost Particle of the Atom",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1966."
                },
                new Book
                {
                    Title = "The Roman Republic",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1966."
                },
                new Book
                {
                    Title = "Understanding Physics, 3 volumes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1966. Vol. I: Motion, Sound, and Heat. Vol. II: Light, Magnetism, and Electricity. Vol. III: The Electron, Proton, and Neutron."
                },
                new Book
                {
                    Title = "The Genetic Effects of Radiation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by U.S. AEC in 1966."
                },
                new Book
                {
                    Title = "The Universe: From Flat Earth to Quasar",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1966. 2nd edition, 1971. 3rd edition, 1980, as The Universe: From Flat Earth to Black Holes and Beyond."
                },
                new Book
                {
                    Title = "From Earth to Heaven",
                    Author = "Isaac Asimov",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1966."
                },
                new Book
                {
                    Title = "The Moon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1967."
                },
                new Book
                {
                    Title = "Environments Out There",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Scholastic/Abelard-Schuman in 1967."
                },
                new Book
                {
                    Title = "The Roman Empire",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1967."
                },
                new Book
                {
                    Title = "Through a Glass, Clearly",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.Novel,
                    Description = "First published by New English Library in 1967."
                },
                new Book
                {
                    Title = "Is Anyone There?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1967."
                },
                new Book
                {
                    Title = "To the Ends of the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1967."
                },
                new Book
                {
                    Title = "Mars",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1967."
                },
                new Book
                {
                    Title = "The Egyptians",
                    Author = "Isaac Asimov",
                    PublicationYear = 1967,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1967."
                },
                new Book
                {
                    Title = "Asimov's Mysteries",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1968."
                },
                new Book
                {
                    Title = "Science, Numbers, and I",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1968."
                },
                new Book
                {
                    Title = "The Near East: 10,000 Years of History",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1968."
                },
                new Book
                {
                    Title = "The Dark Ages",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1968."
                },
                new Book
                {
                    Title = "Asimov's Guide to the Bible, Volume I",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1968."
                },
                new Book
                {
                    Title = "Words from History",
                    Author = "Isaac Asimov",
                    PublicationYear = 1968,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1968.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Photosynthesis",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Basic Books in 1969."
                },
                new Book
                {
                    Title = "The Shaping of England",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1969."
                },
                new Book
                {
                    Title = "Twentieth Century Discovery",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1969."
                },
                new Book
                {
                    Title = "Nightfall and Other Stories",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1969."
                },
                new Book
                {
                    Title = "Asimov's Guide to the Bible, Volume II",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1969."
                },
                new Book
                {
                    Title = "Opus 100",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1969."
                },
                new Book
                {
                    Title = "ABC's of Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1969.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Great Ideas of Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1969."
                },
                new Book
                {
                    Title = "The Solar System and Back",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1970."
                },
                new Book
                {
                    Title = "Asimov's Guide to Shakespeare, 2 volumes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1970."
                },
                new Book
                {
                    Title = "Constaninople: The Forgotten Empire",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1970."
                },
                new Book
                {
                    Title = "ABC's of the Ocean",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1970.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Light",
                    Author = "Isaac Asimov",
                    PublicationYear = 1970,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1970."
                },
                new Book
                {
                    Title = "The Stars in Their Courses",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1971."
                },
                new Book
                {
                    Title = "What Makes the Sun Shine?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Little, Brown & Co. in 1971."
                },
                new Book
                {
                    Title = "The Next Best Thing",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.Novel,
                    Description = "First published by World Pub. Co. in 1971.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Land of Canaan",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1971."
                },
                new Book
                {
                    Title = "The ABC's of the Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1971.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Sensuous Dirty Old Man",
                    Author = "Isaac Asimov",
                    WrittenAs = "Dr. A.",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1971."
                },
                new Book
                {
                    Title = "Isaac Asimov's Treasury of Humor",
                    Author = "Isaac Asimov",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1971."
                },
                new Book
                {
                    Title = "The Left Hand of the Electron",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1972."
                },
                new Book
                {
                    Title = "The Gods Themselves",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1972."
                },
                new Book
                {
                    Title = "More Words of Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Electricity and Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by U.S. AEC in 1972."
                },
                new Book
                {
                    Title = "ABC's of Ecology",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Early Asimov or, Eleven Years of Trying",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1972."
                },
                new Book
                {
                    Title = "The Shaping of France",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1972."
                },
                new Book
                {
                    Title = "The Story of Ruth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Ginn Science Program, Intermediate Level A",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Ginn in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Ginn Science Program, Intermediate Level C",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Ginn in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Worlds Within Worlds",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by U.S. AEC in 1972."
                },
                new Book
                {
                    Title = "Ginn Science Program, Intermediate Level B",
                    Author = "Isaac Asimov",
                    PublicationYear = 1972,
                    Type = BookType.NonFiction,
                    Description = "First published by Ginn in 1972.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out the Earth Is Round?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Comets and Meteors (1973)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1973."
                },
                new Book
                {
                    Title = "The Sun (1973)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1973."
                },
                new Book
                {
                    Title = "How Did We Find Out About Electricity?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Shaping of North America: From Earliest Times to 1763",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1973."
                },
                new Book
                {
                    Title = "Today and Tomorrow and ... ",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1973."
                },
                new Book
                {
                    Title = "Jupiter, the Largest Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Lothrop, Lee, & Shepard in 1973."
                },
                new Book
                {
                    Title = "Ginn Science Program, Advanced Level A",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Ginn in 1973."
                },
                new Book
                {
                    Title = "Ginn Science Program, Advanced Level B",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Ginn in 1973."
                },
                new Book
                {
                    Title = "How Did We Find Out About Numbers?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Please Explain",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1973."
                },
                new Book
                {
                    Title = "The Tragedy of the Moon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Abelard-Schuman in 1973."
                },
                new Book
                {
                    Title = "How Did We Find Out About Dinosaurs?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1973.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Best of Isaac Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1973,
                    Type = BookType.Novel,
                    Description = "First published by Sphere in 1973."
                },
                new Book
                {
                    Title = "Asimov on Astronomy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1974."
                },
                new Book
                {
                    Title = "The Birth of the United States: 1763-1816",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1974."
                },
                new Book
                {
                    Title = "Have You Seen These?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.Novel,
                    Description = "First published by NESRAA in 1974."
                },
                new Book
                {
                    Title = "Our World in Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by New York Graphic Society in 1974."
                },
                new Book
                {
                    Title = "How Did We Find Out About Germs?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Tales of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1974."
                },
                new Book
                {
                    Title = "Earth: Our Crowded Spaceship",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by John Day in 1974."
                },
                new Book
                {
                    Title = "Asimov on Chemistry",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1974."
                },
                new Book
                {
                    Title = "How Did We Find Out About Vitamins?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1974,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1974.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Of Matters Great and Small",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1975."
                },
                new Book
                {
                    Title = "The Solar System",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Follet in 1975."
                },
                new Book
                {
                    Title = "Our Federal Union: The United States from 1816 to 1865",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1975."
                },
                new Book
                {
                    Title = "How Did We Find Out About Comets?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1975."
                },
                new Book
                {
                    Title = "Science Past, Science Future",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1975."
                },
                new Book
                {
                    Title = "Buy Jupiter and Other Stories",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1975."
                },
                new Book
                {
                    Title = "Eyes on the Universe: A History of the Telescope",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1975."
                },
                new Book
                {
                    Title = "Lecherous Limericks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1975."
                },
                new Book
                {
                    Title = "The Heavenly Host (Novel)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1975. Illustrations by Bernard Colonna.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Ends of the Earth: The Polar Regions of the World",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Weybright & Talley in 1975."
                },
                new Book
                {
                    Title = "How Did We Find Out About Energy?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1975,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1975.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Dream, Benjamin's Dream, and Benjamin's Bicentennial Blast",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.Novel,
                    Description = "First published by Benjamin Franklin Keeps in 1976."
                },
                new Book
                {
                    Title = "Asimov on Physics",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1976."
                },
                new Book
                {
                    Title = "Murder at the ABA",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1976. Republished as Authorized Murder in 1979."
                },
                new Book
                {
                    Title = "How Did We Find Out About Atoms?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Good Taste (Collection)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.Novel,
                    Description = "First published by Apocalypse Press in 1976."
                },
                new Book
                {
                    Title = "The Planet That Wasn't",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1976."
                },
                new Book
                {
                    Title = "More Lecherous Limericks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1976."
                },
                new Book
                {
                    Title = "More Tales of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday/Crime Club in 1976."
                },
                new Book
                {
                    Title = "Alpha Centauri, the Nearest Star",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Lothrop, Lee, & Shepard in 1976."
                },
                new Book
                {
                    Title = "How Did We Find Out About Nuclear Power?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1976,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1976.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Collapsing Universe: The Story of Black Holes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1977."
                },
                new Book
                {
                    Title = "Asimov on Numbers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1977."
                },
                new Book
                {
                    Title = "How Did We Find Out About Outer Space?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1977.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Still More Lecherous Limericks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1977."
                },
                new Book
                {
                    Title = "The Beginning and the End",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1977."
                },
                new Book
                {
                    Title = "Mars, the Red Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Lothrop, Lee, & Shepard in 1977."
                },
                new Book
                {
                    Title = "The Golden Door: The United States from 1865 to 1918",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1977."
                },
                new Book
                {
                    Title = "The Key Word and Other Mysteries",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1977."
                },
                new Book
                {
                    Title = "Asimov's Sherlockian Limericks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1977,
                    Type = BookType.NonFiction,
                    Description = "First published by Mysterious Press in 1977."
                },
                new Book
                {
                    Title = "Quasar, Quasar, Burning Bright",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1978."
                },
                new Book
                {
                    Title = "How Did We Find Out About Earthquakes?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Animals of the Bible",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Limericks: Too Gross; or Two Dozen Dirty Stanzas",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.NonFiction,
                    Description = "First published by W. W. Norton in 1978."
                },
                new Book
                {
                    Title = "How Did We Find Out About Black Holes?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1978.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Life and Time",
                    Author = "Isaac Asimov",
                    PublicationYear = 1978,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1978."
                },
                new Book
                {
                    Title = "Saturn and Beyond",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Lothrop, Lee, & Shepard in 1979."
                },
                new Book
                {
                    Title = "Opus 200",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1979."
                },
                new Book
                {
                    Title = "In Memory Yet Green: The Autobiography of Isaac Asimov, 1920-1954",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1979."
                },
                new Book
                {
                    Title = "Extraterrestrial Civilizations",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Crown in 1979."
                },
                new Book
                {
                    Title = "How Did We Find Out About Our Human Roots?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Road to Infinity",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1979."
                },
                new Book
                {
                    Title = "A Choice of Catastrophes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Simon & Schuster in 1979."
                },
                new Book
                {
                    Title = "Isaac Asimov's Book of Facts",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Grosset & Dunlap in 1979."
                },
                new Book
                {
                    Title = "How Did We Find Out About Antarctica?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1979.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Threats of Our World",
                    Author = "Isaac Asimov",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1979."
                },
                new Book
                {
                    Title = "Casebook of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1980."
                },
                new Book
                {
                    Title = "How Did We Find Out About Oil?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1980."
                },
                new Book
                {
                    Title = "In Joy Still Felt: The Autobiography of Isaac Asimov, 1954-1978",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1980."
                },
                new Book
                {
                    Title = "How Did We Find Out About Coal?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1980,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1980."
                },
                new Book
                {
                    Title = "In the Beginning: Science Faces God in the Book of Genesis",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Crown/Stonesong Press in 1981."
                },
                new Book
                {
                    Title = "Asimov on Science Fiction",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1981."
                },
                new Book
                {
                    Title = "Venus, Near Neighbor of the Sun",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Lothrop, Lee, & Shepard in 1981."
                },
                new Book
                {
                    Title = "Three by Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.Novel,
                    Description = "First published by Targ in 1981."
                },
                new Book
                {
                    Title = "How Did We Find Out About Solar Power?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1981."
                },
                new Book
                {
                    Title = "How Did We Find Out About the Volcanoes?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1981."
                },
                new Book
                {
                    Title = "Visions of the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by The Cosmos Store in 1981."
                },
                new Book
                {
                    Title = "The Sun Shines Bright",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1981."
                },
                new Book
                {
                    Title = "Change! Seventy-one Glimpses of the Future",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1981."
                },
                new Book
                {
                    Title = "A Grossery of Limericks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1981,
                    Type = BookType.NonFiction,
                    Description = "First published by W. W. Norton in 1981."
                },
                new Book
                {
                    Title = "How Did We Find Out About Life in the Deep Sea?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Complete Robot",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1982."
                },
                new Book
                {
                    Title = "Exploring the Earth and the Cosmos",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.NonFiction,
                    Description = "First published by Crown in 1982."
                },
                new Book
                {
                    Title = "How Did We Find Out About the Beginning of Life?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Isaac Asimov Presents Superquiz",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.NonFiction,
                    Description = "First published by Dembner Books in 1982."
                },
                new Book
                {
                    Title = "Foundation's Edge",
                    Author = "Isaac Asimov",
                    PublicationYear = 1982,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1982.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About the Universe?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Counting the Eons",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1983."
                },
                new Book
                {
                    Title = "The Winds of Change and Other Stories",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1983."
                },
                new Book
                {
                    Title = "The Measure of the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.NonFiction,
                    Description = "First published by Harper & Row in 1983."
                },
                new Book
                {
                    Title = "The Union Club Mysteries",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1983."
                },
                new Book
                {
                    Title = "Norby, the Mixed-up Robot",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Robots of Dawn",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About Genes?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1983.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Isaac Asimov Presents Superquiz II",
                    Author = "Isaac Asimov",
                    PublicationYear = 1983,
                    Type = BookType.NonFiction,
                    Description = "First published by Dembner Books in 1983."
                },
                new Book
                {
                    Title = "X Stands for Unknown",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1984."
                },
                new Book
                {
                    Title = "Norby's Other Secret",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About Computers?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Opus 300",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1984."
                },
                new Book
                {
                    Title = "Banquets of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1984."
                },
                new Book
                {
                    Title = "How Did We Find Out About Robots?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1984,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1984.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Asimov's Guide to Halley's Comet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1985."
                },
                new Book
                {
                    Title = "The Exploding Suns: The Secrets of the Supernovas",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction,
                    Description = "First published by E. P. Dutton in 1985."
                },
                new Book
                {
                    Title = "Norby and the Lost Princess",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About the Atmosphere?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction, 
                    Description = "First published by Walker in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Living in the Future",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction,
                    Description = "First published by Harmony House in 1985."
                },
                new Book
                {
                    Title = "Robots: Machines In Man's Image",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction,
                    Description = "First published by Harmony House in 1985."
                },
                new Book
                {
                    Title = "The Edge of Tomorrow",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Tor/Tom Doherty Associates in 1985."
                },
                new Book
                {
                    Title = "The Subatomic Monster",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1985."
                },
                new Book
                {
                    Title = "The Disappearing Man and Other Mysteries",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1985."
                },
                new Book
                {
                    Title = "Robots and Empire",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "Norby and the Invaders",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About DNA?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1985,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1985.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Dangers of Intelligence and Other Science Essays",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Houghton Mifflin in 1986."
                },
                new Book
                {
                    Title = "The Alternate Asimovs",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1986."
                },
                new Book
                {
                    Title = "How Did We Find Out About the Speed of Light?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Futuredays: A Nineteenth-Century Vision of the Year 2000",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Henry Holt in 1986."
                },
                new Book
                {
                    Title = "Science Fiction by Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Davis Publications in 1986."
                },
                new Book
                {
                    Title = "The Best Science Fiction of Isaac Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1986."
                },
                new Book
                {
                    Title = "The Best Mysteries of Isaac Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1986."
                },
                new Book
                {
                    Title = "Foundation and Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "Norby and the Queen's Necklace",
                    Author = "Isaac Asimov",
                    PublicationYear = 1986,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1986.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Far as Human Eye Could See: Essays on Science",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1987."
                },
                new Book
                {
                    Title = "How Did We Find Out About Blood?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Past, Present, and Future",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Prometheus Books in 1987."
                },
                new Book
                {
                    Title = "Isaac Asimov Presents Superquiz III",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Dembner Books in 1987."
                },
                new Book
                {
                    Title = "How Did We Find Out About Sunshine?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How to Enjoy Writing: A Book of Aid and Comfort",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1987."
                },
                new Book
                {
                    Title = "Norby Finds a Villain",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1987.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Fantastic Voyage II: Destination Brain",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1987."
                },
                new Book
                {
                    Title = "How Did We Find Out About the Brain?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1987."
                },
                new Book
                {
                    Title = "Did Comets Kill the Dinosaurs?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1987."
                },
                new Book
                {
                    Title = "Beginnings: The Story of Origins of Mankind, Life, the Earth, the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1987."
                },
                new Book
                {
                    Title = "Other Worlds of Isaac Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1987,
                    Type = BookType.NonFiction,
                    Description = "First published by Avenel in 1987."
                },
                new Book
                {
                    Title = "How Did We Find Out About Superconductivity?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1988."
                },
                new Book
                {
                    Title = "The Relativity of Wrong",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1988."
                },
                new Book
                {
                    Title = "Prelude to Foundation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" }
                    }
                },
                new Book
                {
                    Title = "The Asteroids",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Earth's Moon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Mars: Our Mysterious Neighbor",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Our Milky Way and Other Galaxies",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Quasars, Pulsars, and Black Holes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Rockets, Probes, and Satellites",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Our Solar System",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Sun (1988)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Uranus: The Sideways Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "History of Biology [A chart]",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Carolina Biological Suppls. in 1988."
                },
                new Book
                {
                    Title = "Azazel",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1988."
                },
                new Book
                {
                    Title = "Isaac Asimov's Science Fiction and Fantasy Story-a-Month 1989 Calendar",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Pomegranate Calendars & Bks in 1988."
                },
                new Book
                {
                    Title = "Saturn: The Ringed Beauty",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Was the Universe Born?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Earth: Our Home Base",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Ancient Astronomy",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Unidentified Flying Objects",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Space Spotter's Guide",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Norby Down to Earth",
                    Author = "Isaac Asimov",
                    PublicationYear = 1988,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1988.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "How Did We Find Out About Microwaves?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1989."
                },
                new Book
                {
                    Title = "Asimov's Galaxy: Reflections on Science Fiction",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1989."
                },
                new Book
                {
                    Title = "Is There Life on Other Planets?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Science Fiction, Science Fact",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Mercury: The Quick Planet",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Space Garbage",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Jupiter: The Spotted Giant",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Birth and Death of Stars",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The History of Mathematics [a chart]",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Carolina Biological Suppls. in 1989."
                },
                new Book
                {
                    Title = "Think About Space: Where Have We Been and Where Are We Going?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1989. With Frank White."
                },
                new Book
                {
                    Title = "Isaac Asimov Presents Superquiz IV",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Dembner Books in 1989."
                },
                new Book
                {
                    Title = "The Tyrannosaurus Prescription: and One Hundred Other Science Essays",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Prometheus Books in 1989."
                },
                new Book
                {
                    Title = "Asimov on Science: A 30 Year Retrospective 1959-1989",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1989."
                },
                new Book
                {
                    Title = "Nemesis",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "Asimov's Chronology of Science and Discovery",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Harper & Row in 1989."
                },
                new Book
                {
                    Title = "How Did We Find Out About Photosynthesis?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Complete Science Fair Handbooks",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Scott Foresman & Co in 1989."
                },
                new Book
                {
                    Title = "Little Treasury of Dinosaurs",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Outlet in 1989. 5 book set. Giant Dinosaurs, Armored Dinosaurs, Small Dinosaurs, Sea Reptiles and Flying Reptiles, Meat-Eating Dinosaurs and Horned Dinosaurs.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Norby and Yobo's Great Adventure",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Mythology and the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Colonizing the Planets and the Stars",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Astronomy Today",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Pluto: A Double Planet?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Piloted Space Flights",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Comets and Meteors (1989)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Puzzles of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1989."
                },
                new Book
                {
                    Title = "Norby and the Oldest Dragon",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Frontiers: New Discoveries About Man and His Planet, Outer Space and the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by E. P. Dutton/Truman in 1989."
                },
                new Book
                {
                    Title = "Out of the Everywhere: Thoughts on Science from the Master",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1989."
                },
                new Book
                {
                    Title = "Robot Visions (Collection)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Byron Preiss in 1989. Contains an 18 page introduction later reprinted in 'Gold', and 16 essays"
                },
                new Book
                {
                    Title = "How Did We Find Out About Lasers?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1989."
                },
                new Book
                {
                    Title = "Neptune: The Farthest Giant",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1989.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The March of the Millennia: A Key to Looking at History",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1989. Republished by Walker in 1991."
                },
                new Book
                {
                    Title = "Cal: A Short Story Written Exclusively for Members of the Isaac Asimov Collection",
                    Author = "Isaac Asimov",
                    PublicationYear = 1989,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1989."
                },
                new Book
                {
                    Title = "Norby and the Court Jester",
                    Author = "Isaac Asimov",
                    PublicationYear = 1990,
                    Type = BookType.Novel,
                    Description = "First published by Walker in 1990.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "The Secret of the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1991."
                },
                new Book
                {
                    Title = "How Did We Find Out About Pluto?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Walker in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Atom: Journey Across the Subatomic Cosmos",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by E. P. Dutton/Truman in 1991."
                },
                new Book
                {
                    Title = "Our Angry Earth: A Ticking Ecological Bomb",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Tor in 1991. Co-written with Frederik Pohl. 2018 edition includes intro/afterword by Kim Stanley Robinson.",
                },
                new Book
                {
                    Title = "Why Do We Have Different Seasons?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Is Our Planet Warming Up?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Is the Air Dirty?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Are Whales Vanishing?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Where Does Garbage Go?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "What Causes Acid Rain?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "What Is a Shooting Star?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Do Stars Twinkle?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Does the Moon Change Shape?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "What Is an Eclipse?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Isaac Asimov's Guide to Earth and Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Random House in 1991."
                },
                new Book
                {
                    Title = "Asimov's Chronology of the World",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by HarperCollins in 1991."
                },
                new Book
                {
                    Title = "Christopher Columbus: Navigator to the New World",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991."
                },
                new Book
                {
                    Title = "Ferdinand Magellan: Opening the Door to World Exploration",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1991."
                },
                new Book
                {
                    Title = "The History of Chemistry [a chart]",
                    Author = "Isaac Asimov",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "First published by Carolina Biological Suppls. in 1991."
                },
                new Book
                {
                    Title = "The Ugly Little Boy (Novel)",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1992. Co-written with Robert Silverberg."
                },
                new Book
                {
                    Title = "The Complete Stories, Volume 2",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1992."
                },
                new Book
                {
                    Title = "Why Are Some Beaches Oily?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Are Animals Endangered?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Are the Rain Forests Vanishing?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Why Does Litter Cause Problems?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Asimov Laughs Again: More Than 700 Favorite Jokes, Limericks, and Anecdotes",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by HarperCollins in 1992."
                },
                new Book
                {
                    Title = "What's Happening to the Ozone Layer?",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Forward the Foundation",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Foundation Universe" },
                        new Tag { Name = "Foundation Series" }
                    }
                },
                new Book
                {
                    Title = "The Positronic Man",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 1992. Co-written with Robert Silverberg. Based on the short story 'The Bicentennial Man', and made into the movie 'The Bicentennial Man' in 1999 starring Robin Williams.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Screen" },
                        new Tag { Name = "Robot" },
                        new Tag { Name = "Foundation Universe" }
                    }
                },
                new Book
                {
                    Title = "The Future in Space",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by Gareth Stevens, Inc in 1992.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Juvenile" }
                    }
                },
                new Book
                {
                    Title = "Frontiers II: More Recent Discoveries About Life, Earth, Space, and the Universe",
                    Author = "Isaac Asimov",
                    PublicationYear = 1992,
                    Type = BookType.NonFiction,
                    Description = "First published by E. P. Dutton/Truman in 1992."
                },
                new Book
                {
                    Title = "I. Asimov: A Memoir",
                    Author = "Isaac Asimov",
                    PublicationYear = 1994,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1994."
                },
                new Book
                {
                    Title = "Gold: The Final Science Fiction Collection",
                    Author = "Isaac Asimov",
                    PublicationYear = 1995,
                    Type = BookType.Novel,
                    Description = "First published by HarperPrism in 1995. 15 Short Stories and 37 Essays."
                },
                new Book
                {
                    Title = "Yours, Isaac Asimov",
                    Author = "Isaac Asimov",
                    PublicationYear = 1995,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 1995."
                },
                new Book
                {
                    Title = "Magic: The Final Fantasy Collection",
                    Author = "Isaac Asimov",
                    PublicationYear = 1996,
                    Type = BookType.Novel,
                    Description = "First published by HarperPrism in 1996."
                },
                new Book
                {
                    Title = "It's Been a Good Life",
                    Author = "Isaac Asimov",
                    PublicationYear = 2002,
                    Type = BookType.NonFiction,
                    Description = "First published by Doubleday in 2002. Condensed from three autobiographical volumes edited by Asimov's widow."
                },
                new Book
                {
                    Title = "The Return of the Black Widowers",
                    Author = "Isaac Asimov",
                    PublicationYear = 2003,
                    Type = BookType.Novel,
                    Description = "First published by Doubleday in 2003."
                },
                new Book
                {
                    Title = "Dumb Luck",
                    Author = "Isaac Asimov",
                    PublicationYear = 2003,
                    Type = BookType.ShortStory,
                    Description = "Unpublished Union Club story.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Union Club" }
                    }
                },
                new Book
                {
                    Title = "Tower of Babylon",
                    Author = "Ted Chiang",
                    PublicationYear = 1990,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "Chiang's first published story, originally published in Omni Magazine in November 1990. Nominated for the 1991 Locus Award for Best Novelette. Nominated for the 1991 Hugo Award for Best Novelette. Won the 1991 Nebula Award for Best Novelette. Won the 1992 Astounding Award for Best New Writer.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "Understand",
                    Author = "Ted Chiang",
                    PublicationYear = 1991,
                    PublicationMonth = 8,
                    Type = BookType.ShortStory,
                    Description = "Originally published in Asimov's Science Fiction Magazine in August 1991. Won the 1991 Asimov's Readers' Poll for Best Novelette. Nominated for the 1992 Locus Award for Best Novelette. Nominated for the 1992 Hugo Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" },
                        new Tag { Name = "Adapted for Radio" }
                    }
                },
                new Book
                {
                    Title = "Division by Zero",
                    Author = "Ted Chiang",
                    PublicationYear = 1991,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'Full Spectrum 3' in May 1991. Nominated for the 1992 Locus Award for Best Short Story.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "Story of Your Life",
                    Author = "Ted Chiang",
                    PublicationYear = 1998,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "Adapted for screen as the 2016 film 'Arrival' (nominated for eight Academy Awards, won Ray Bradbury Award and a Hugo for Best Dramatic Presenation). Originally published in the anthology 'Starlight 2' in November 1998. Won the 1998 Otherwise Award for Best Short Story. Nominated for the 1998 HOMer Award for Best Novelette. Nominated for the 1999 Locus Award for Best Novelette. Nominated for the 1999 Hugo Award for Best Novelette. Won the 1999 Theodore Sturgeon Award for Best Short Story. Won the 2000 Nebula Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" },
                        new Tag { Name = "Adapted for Screen" }
                    }
                },
                new Book
                {
                    Title = "Seventy-Two Letters",
                    Author = "Ted Chiang",
                    PublicationYear = 2000,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'Vanishing Act' in June 2000. Won the 2000 Sidewise Award for Alternate History for Best Short Form. Nominated for the 2001 Theodore Sturgeon Award for Best Short Science Fiction. Nominated for the 2001 World Fantasy Award for Best Novella. Nominated for the 2001 Hugo Award for Best Novella. Nominated for the 2001 Locus Award for Best Novella.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "The Evolution of Human Science",
                    Author = "Ted Chiang",
                    PublicationYear = 2000,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "Originally titled 'Catching Crumbs from the Table' and published in Nature Magazine in June 2000. Nominated for the 2001 Locus Award for Best Short Story.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "Hell Is the Absence of God",
                    Author = "Ted Chiang",
                    PublicationYear = 2001,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'Starlight 3' in July 2001. Won the 2002 Hugo Award for Best Novelette. Won the 2002 Locus Award for Best Novelette. Won the 2003 Nebula Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "Liking What You See: A Documentary",
                    Author = "Ted Chiang",
                    PublicationYear = 2002,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the collection 'Stories of Your Life and Others' in 2002. Chiang withdrew a nomination for the 2003 Hugo Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Stories of Your Life and Others" }
                    }
                },
                new Book
                {
                    Title = "The Merchant and the Alchemist's Gate",
                    Author = "Ted Chiang",
                    PublicationYear = 2007,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "An Alchemist provides a doorway to the past or the future, but can it be changed? Nominated for the 2007 BSFA Award for Short Fiction, Won the 2008 Hugo Award for Best Novelette. Won the 2008 Nebula Award for Best Novelette. Nominated for the 2008 Locus Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "Exhalation",
                    Author = "Ted Chiang",
                    PublicationYear = 2008,
                    PublicationMonth = 11,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'Eclipse 2' in November 2008. Won the 2008 BSFA Award for Short Fiction. Won the 2009 Hugo Award for Best Short Story. Won the 2009 Locus Award for Best Short Story.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "What's Expected of Us",
                    Author = "Ted Chiang",
                    PublicationYear = 2005,
                    PublicationMonth = 7,
                    Type = BookType.ShortStory,
                    Description = "A device predicts our behavior, but what effect does it have on us?Originally published in Nature Magazine in July 2005. Included in the 2006 anthology Year's Best SF 11 and in the 2019 collection Exhalation: Stories.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "The Lifecycle of Software Objects",
                    Author = "Ted Chiang",
                    PublicationYear = 2010,
                    Type = BookType.ShortStory,
                    Description = "Won the 2011 Hugo Award for Best Novella. Nominated for the 2011 Nebula Award for Best Novella. Won the 2011 Locus Award for Best Novella.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "Dacey's Patent Automatic Nanny",
                    Author = "Ted Chiang",
                    PublicationYear = 2011,
                    PublicationMonth = 6,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'The Thackery T. Lambshead Cabinet of Curiosities' in 2011. Included in the 2019 collection Exhalation: Stories.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "The Truth of Fact, the Truth of Feeling",
                    Author = "Ted Chiang",
                    PublicationYear = 2013,
                    Type = BookType.ShortStory,
                    Description = "Nominated for the 2014 Locus Award for Best Novelette. Nominated for the 2014 Hugo Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "The Great Silence",
                    Author = "Ted Chiang",
                    PublicationYear = 2015,
                    Type = BookType.ShortStory,
                    Description = "Originally published in the anthology 'e-flux Journal' in May 2015. Included in the 2016 anthology The Best American Short Stories and in the 2019 collection Exhalation: Stories.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "Omphalos",
                    Author = "Ted Chiang",
                    PublicationYear = 2019,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in the collection 'Exhalation: Stories' in May 2019. Nominated for the 2020 Hugo Award for Best Novelette. Won the 2020 Locus Award for Best Novelette.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "Anxiety Is the Dizziness of Freedom",
                    Author = "Ted Chiang",
                    PublicationYear = 2019,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in the collection 'Exhalation: Stories' in May 2019. Nominated for the 2020 Hugo Award for Best Novella. Nominated for the 2020 Nebula Award for Best Novella. Nominated for the 2020 Locus Award for Best Novella.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Exhalation Stories" }
                    }
                },
                new Book
                {
                    Title = "It's 2059, and the Rich Kids are Still Winning",
                    Author = "Ted Chiang",
                    PublicationYear = 2019,
                    PublicationMonth = 5,
                    Type = BookType.ShortStory,
                    Description = "First published in the New York Times in May 2019 and then in 'The Year's Best Science Fiction 2020'. Nominated for the 2020 Locus Award for Best Short Story."
                },
                new Book
                {
                    Title = "Frankenstein's Daughter by Maureen McHugh: An Appreciation",
                    Author = "Ted Chiang",
                    PublicationYear = 2005,
                    PublicationMonth = 12,
                    Type = BookType.NonFiction,
                    Description = "First published in the The Ellen Datlow/SCI FICTION Project in December 2005."
                },
                new Book
                {
                    Title = "The Problem of the Traveling Salesman",
                    Author = "Ted Chiang",
                    PublicationYear = 2008,
                    PublicationMonth = 11,
                    Type = BookType.NonFiction,
                    Description = "First published in the Lady Churchill's Rosebud Wristlet #23 in November 2008."
                },
                new Book
                {
                    Title = "Reasoning About the Body",
                    Author = "Ted Chiang",
                    PublicationYear = 2010,
                    PublicationMonth = 11,
                    Type = BookType.NonFiction,
                    Description = "First published in the Lady Churchill's Rosebud Wristlet #26 in November 2010."
                },
                new Book
                {
                    Title = "Introduction to 'Particle Theory'",
                    Author = "Ted Chiang",
                    PublicationYear = 2011,
                    PublicationMonth = 10,
                    Type = BookType.Forward,
                    Description = "First published in Strange Horizons in October 2011."
                },
                new Book
                {
                    Title = "Bad Character",
                    Author = "Ted Chiang",
                    PublicationYear = 2016,
                    PublicationMonth = 5,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in May 2016."
                },
                new Book
                {
                    Title = "Silicon Valley Is Turning Into Its Own Worst Fear",
                    Author = "Ted Chiang",
                    PublicationYear = 2017,
                    PublicationMonth = 12,
                    Type = BookType.NonFiction,
                    Description = "First published on BuzzFeed in December 2017."
                },
                new Book
                {
                    Title = "What If Parents Loved Strangers' Children As Much As Their Own?",
                    Author = "Ted Chiang",
                    PublicationYear = 2017,
                    PublicationMonth = 12,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in December 2017."
                },
                new Book
                {
                    Title = "Why Computers Won't Make Themselves Smarter",
                    Author = "Ted Chiang",
                    PublicationYear = 2021,
                    PublicationMonth = 3,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in March 2021."
                },
                new Book
                {
                    Title = "The Art and Science of Arrival by Tanya Lapointe",
                    Author = "Ted Chiang",
                    PublicationYear = 2022,
                    Type = BookType.Forward,
                },
                new Book
                {
                    Title = "The History of Science Fiction: A Graphic Novel Adventure by Xavier Dollo",
                    Author = "Ted Chiang",
                    PublicationYear = 2022,
                    Type = BookType.Forward,
                },
                new Book
                {
                    Title = "ChatGPT Is a Blurry JPEG of the Web",
                    Author = "Ted Chiang",
                    PublicationYear = 2023,
                    PublicationMonth = 2,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in February 2023."
                },
                new Book
                {
                    Title = "Will A.I. Become the New McKinsey?",
                    Author = "Ted Chiang",
                    PublicationYear = 2023,
                    PublicationMonth = 5,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in May 2023."
                },
                new Book
                {
                    Title = "Why A.I. Isn't Going to Make Art",
                    Author = "Ted Chiang",
                    PublicationYear = 2024,
                    PublicationMonth = 8,
                    Type = BookType.NonFiction,
                    Description = "First published in the New Yorker in August 2024. Won the 2024 BSFA Award for Short Non-Fiction.",
                },
                new Book
                {
                    Title = "Ideal",
                    Author = "Ayn Rand",
                    PublicationYear = 1934,
                    Type = BookType.Novel,
                    Description = "Written in 1934, published posthumously in 2015.",
                },
                new Book
                {
                    Title = "We the Living",
                    Author = "Ayn Rand",
                    PublicationYear = 1936,
                    Type = BookType.Novel,
                    Description = "Written and published in 1936, revised edition published in 1959. 60th anniversary edition published by New American Library in 1996, includes an introduction by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "Anthem",
                    Author = "Ayn Rand",
                    PublicationYear = 1938,
                    Type = BookType.Novel,
                    Description = "Written and published in 1938, revised edition published in 1946. 50th anniversary edition published by Pamphleteers in 1995, includes the revised edition text plus a facsimile of the first edition.",
                },
                new Book
                {
                    Title = "The Fountainhead",
                    Author = "Ayn Rand",
                    PublicationYear = 1943,
                    Type = BookType.Novel,
                    Description = "Written and published in 1943, revised edition published in 1971. 25th anniversary edition published by Bobbs-Merrill in 1971, includes a new introduction by Rand. 50th anniversary edition published by Bobbs-Merrill in 1993, includes an afterword by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "Atlas Shrugged",
                    Author = "Ayn Rand",
                    PublicationYear = 1957,
                    Type = BookType.Novel,
                    Description = "Written and published in 1957, revised edition published in 1992. 35th anniversary edition published by Dutton in 1992, includes an introduction by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "The Husband I Bought",
                    Author = "Ayn Rand",
                    PublicationYear = 1926,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1926, published in 1984 in 'The Early Ayn Rand'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Ayn Rand" }
                    }
                },
                new Book
                {
                    Title = "The Night King",
                    Author = "Ayn Rand",
                    PublicationYear = 1926,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1926, published in 1984 in 'The Early Ayn Rand'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Ayn Rand" }
                    }
                },
                new Book
                {
                    Title = "Good Copy",
                    Author = "Ayn Rand",
                    PublicationYear = 1927,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1927, published in 1984 in 'The Early Ayn Rand'.",
                },
                new Book
                {
                    Title = "Escort",
                    Author = "Ayn Rand",
                    PublicationYear = 1929,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1929, published in 1984 in 'The Early Ayn Rand'.",
                },
                new Book
                {
                    Title = "Her Second Career",
                    Author = "Ayn Rand",
                    PublicationYear = 1929,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1929, published in 1984 in 'The Early Ayn Rand'.",
                },
                new Book
                {
                    Title = "Red Pawn",
                    Author = "Ayn Rand",
                    PublicationYear = 1931,
                    Type = BookType.ShortStory,
                    Description = "Written circa 1931, published in 1984 in 'The Early Ayn Rand'.",
                },
                new Book
                {
                    Title = "Night of January 16th",
                    Author = "Ayn Rand",
                    PublicationYear = 1934,
                    Type = BookType.Play,
                    Description = "Written and published in 1934, revised edition published in 1968. Stage play, published in The Early Ayn Rand prior to first production.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Three Plays" }
                    }
                },
                new Book
                {
                    Title = "The Unconquered",
                    Author = "Ayn Rand",
                    PublicationYear = 1940,
                    Type = BookType.Play,
                    Description = "Written and published in 1940, revised edition published in 2014. Stage adaptation of We the Living, two versions of the script, edited by Robert Mayhew, published by Palgrave Macmillan in 2014",
                },
                new Book
                {
                    Title = "Love Letters",
                    Author = "Ayn Rand",
                    PublicationYear = 1945,
                    Type = BookType.Play,
                    Description = "Written and published in 1945, screenplay.",
                },
                new Book
                {
                    Title = "You Came Along",
                    Author = "Ayn Rand",
                    PublicationYear = 1945,
                    Type = BookType.Play,
                    Description = "Written and published in 1945, screenplay, co-written with Robert Smith.",
                },
                new Book
                {
                    Title = "The Fountainhead (Screenplay)",
                    Author = "Ayn Rand",
                    PublicationYear = 1949,
                    Type = BookType.Play,
                    Description = "Written and published in 1949, screenplay adaptation of her own novel.",
                },
                new Book
                {
                    Title = "Ideal (Stage Play)",
                    Author = "Ayn Rand",
                    PublicationYear = 1934,
                    Type = BookType.Play,
                    Description = "Stage play, published in The Early Ayn Rand prior to first production.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Three Plays" },
                        new Tag { Name = "Collection: The Early Ayn Rand" }
                    }
                },
                new Book
                {
                    Title = "Think Twice",
                    Author = "Ayn Rand",
                    PublicationYear = 1939,
                    Type = BookType.Play,
                    Description = "Written in 1939 and published in in 1984 in 'The Early Ayn Rand' and 2005 in 'Three Plays', includes an introduction by Leonard Peikoff.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: Three Plays" },
                        new Tag { Name = "Collection: The Early Ayn Rand" }
                    }
                },
                new Book
                {
                    Title = "The Simplest Thing in the World",
                    Author = "Ayn Rand",
                    PublicationYear = 1940  ,
                    Type = BookType.ShortStory,
                    Description = "Written in 1941 and published in in 1984 in 'The Early Ayn Rand'.",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Collection: The Early Ayn Rand" }
                    }
                },
                new Book
                {
                    Title = "For the New Intellectual: The Philosophy of Ayn Rand",
                    Author = "Ayn Rand",
                    PublicationYear = 1961,
                    Type = BookType.NonFiction,
                    Description = "Written and published in 1961, includes essays by Nathaniel Branden.",
                },
                new Book
                {
                    Title = "The Virtue of Selfishness: A New Concept of Egoism",
                    Author = "Ayn Rand",
                    PublicationYear = 1964,
                    Type = BookType.NonFiction,
                    Description = "Written and published in 1964, includes essays by Nathaniel Branden.",
                },
                new Book
                {
                    Title = "Capitalism: The Unknown Ideal",
                    Author = "Ayn Rand",
                    PublicationYear = 1966,
                    Type = BookType.NonFiction,
                    Description = "Written and published in 1966, includes essays by Nathaniel Branden, Alan Greenspan, and Robert Hessen.",
                },
                new Book
                {
                    Title = "The Romantic Manifesto: A Philosophy of Literature",
                    Author = "Ayn Rand",
                    PublicationYear = 1969,
                    Type = BookType.NonFiction,
                    Description = "Written and published in 1969, expanded second edition published in 1975.",
                },
                new Book
                {
                    Title = "The New Left: The Anti-Industrial Revolution",
                    Author = "Ayn Rand",
                    PublicationYear = 1971,
                    Type = BookType.NonFiction,
                    Description = "Written and published in 1971, expanded second edition published in 1975.",
                },
                new Book
                {
                    Title = "Introduction to Objectivist Epistemology",
                    Author = "Ayn Rand",
                    PublicationYear = 1979,
                    Type = BookType.NonFiction,
                    Description = "Edited by Harry Binswanger and Leonard Peikoff, includes essay by Ayn Rand from The Objectivist in 1967.",
                },
                new Book
                {
                    Title = "Philosophy: Who Needs It",
                    Author = "Ayn Rand",
                    PublicationYear = 1982,
                    Type = BookType.NonFiction,
                    Description = "Edited by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "The Voice of Reason: Essays in Objectivist Thought",
                    Author = "Ayn Rand",
                    PublicationYear = 1989,
                    Type = BookType.NonFiction,
                    Description = "Edited by Leonard Peikoff.  Includes essays by Leonard Peikoff and Peter Schwartz",
                },
                new Book
                {
                    Title = "The Ayn Rand Column: Written for the Los Angeles Times",
                    Author = "Ayn Rand",
                    PublicationYear = 1991,
                    Type = BookType.NonFiction,
                    Description = "Edited by Peter Schwartz. A collection of twenty-six newspaper columns that Rand wrote for the Los Angeles Times from 1962 on, as well as six essays (with an additional three in the revised edition).",
                },
                new Book
                {
                    Title = "Ayn Rand's Marginalia: Her Critical Comments on the Writings of Over 20 Authors",
                    Author = "Ayn Rand",
                    PublicationYear = 1994,
                    Type = BookType.NonFiction,
                    Description = "Edited by Robert Mayhew",
                },
                new Book
                {
                    Title = "Letters of Ayn Rand",
                    Author = "Ayn Rand",
                    PublicationYear = 1995,
                    Type = BookType.NonFiction,
                    Description = "Edited by Michael S. Berliner. Includes an introduction by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "Journals of Ayn Rand",
                    Author = "Ayn Rand",
                    PublicationYear = 1997,
                    Type = BookType.NonFiction,
                    Description = "Edited by David Harriman. Includes a foreword by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "The Ayn Rand Reader",
                    Author = "Ayn Rand",
                    PublicationYear = 1999,
                    Type = BookType.NonFiction,
                    Description = "Edited by Gary Hull and Leonard Peikoff",
                },
                new Book
                {
                    Title = "Return of the Primitive: The Anti-Industrial Revolution",
                    Author = "Ayn Rand",
                    PublicationYear = 1999,
                    Type = BookType.NonFiction,
                    Description = "Revised edition of Rand's earlier book, The New Left, edited by Peter Schwartz and includes essays by Peter Schwartz.",
                },
                new Book
                {
                    Title = "Russian Writings on Hollywood",
                    Author = "Ayn Rand",
                    PublicationYear = 1999,
                    Type = BookType.NonFiction,
                    Description = "Reproduces and translates two booklets previously published in Russia without Rand's knowledge.",
                },
                new Book
                {
                    Title = "Why Businessmen Need Philosophy",
                    Author = "Ayn Rand",
                    PublicationYear = 1999,
                    Type = BookType.NonFiction,
                    Description = "Edited by Richard E. Ralston and published in 1999, includes essays by Leonard Peikoff, Harry Binswanger, Edwin A. Locke, John Ridpath, Richard M. Salsman, and Jaana Woiceshyn.",
                },
                new Book
                {
                    Title = "The Art of Fiction: A Guide for Writers and Readers",
                    Author = "Ayn Rand",
                    PublicationYear = 2000,
                    Type = BookType.NonFiction,
                    Description = "Edited by Tore Boeckmann and published in 2000, includes an introduction by Leonard Peikoff.",
                },
                new Book
                {
                    Title = "The Art of Nonfiction: A Guide for Writers and Readers",
                    Author = "Ayn Rand",
                    PublicationYear = 2001,
                    Type = BookType.NonFiction,
                    Description = "Edited by Robert Mayhew and published in 2001.",
                },
                new Book
                {
                    Title = "Ayn Rand Answers: The Best of Her Q & A",
                    Author = "Ayn Rand",
                    PublicationYear = 2005,
                    Type = BookType.NonFiction,
                    Description = "Edited by Robert Mayhew and published in 2005.",
                },
            };

            var links = new List<Link>
            {
                new Link { BookTitle = "A Bathroom of Her Own", Url = "https://en.wikipedia.org/wiki/A_Bathroom_of_Her_Own", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "All You Zombies", Url = "https://en.wikipedia.org/wiki/%27%E2%80%94All_You_Zombies%E2%80%94%27", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "-And He Built a Crooked House-", Url = "https://en.wikipedia.org/wiki/And_He_Built_a_Crooked_House", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Between Planets", Url = "https://en.wikipedia.org/wiki/Between_Planets", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Beyond Doubt", Url = "https://en.wikipedia.org/wiki/Beyond_Doubt", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Beyond This Horizon", Url = "https://en.wikipedia.org/wiki/Beyond_This_Horizon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Black Pits of Luna", Url = "https://en.wikipedia.org/wiki/The_Black_Pits_of_Luna", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Blowups Happen", Url = "https://en.wikipedia.org/wiki/Blowups_Happen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "By His Bootstraps", Url = "https://en.wikipedia.org/wiki/By_His_Bootstraps", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Cat Who Walks Through Walls", Url = "https://en.wikipedia.org/wiki/The_Cat_Who_Walks_Through_Walls", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Citizen of the Galaxy", Url = "https://en.wikipedia.org/wiki/Citizen_of_the_Galaxy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Columbus Was a Dope", Url = "https://en.wikipedia.org/wiki/Columbus_Was_a_Dope", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Coventry", Url = "https://en.wikipedia.org/wiki/Coventry_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Coventry", Url = "https://archive.org/stream/Astounding_v25n05_1940-07_dtsg0318#page/n55/mode/2up", Label = "Coventry on Archive.org", Description = "Coventry on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Delilah and the Space Rigger", Url = "https://en.wikipedia.org/wiki/Delilah_and_the_Space_Rigger", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Destination Moon", Url = "https://en.wikipedia.org/wiki/Destination_Moon_(story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Door into Summer", Url = "https://en.wikipedia.org/wiki/The_Door_into_Summer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Double Star", Url = "https://en.wikipedia.org/wiki/Double_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Elsewhen", Url = "https://en.wikipedia.org/wiki/Elsewhen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Elsewhen", Url = "https://archive.org/details/Astounding_v28n01_1941-09_SLiV/page/n95", Label = "Elsewhere (1941 version) on Archive.org", Description = "Elsewhere (1941 version) on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Farmer in the Sky", Url = "https://en.wikipedia.org/wiki/Farmer_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Farnham's Freehold", Url = "https://en.wikipedia.org/wiki/Farnham%27s_Freehold", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "For Us, the Living: A Comedy of Customs", Url = "https://en.wikipedia.org/wiki/For_Us,_the_Living:_A_Comedy_of_Customs", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Free Men", Url = "https://en.wikipedia.org/wiki/Free_Men", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Friday", Url = "https://en.wikipedia.org/wiki/Friday_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gentlemen, Be Seated!", Url = "https://en.wikipedia.org/wiki/Gentlemen,_Be_Seated!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Glory Road", Url = "https://en.wikipedia.org/wiki/Glory_Road", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Goldfish Bowl", Url = "https://en.wikipedia.org/wiki/Goldfish_Bowl", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Green Hills of Earth", Url = "https://en.wikipedia.org/wiki/The_Green_Hills_of_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Grumbles from the Grave", Url = "https://en.wikipedia.org/wiki/Grumbles_from_the_Grave", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gulf", Url = "https://en.wikipedia.org/wiki/Gulf_(novella)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Have Space Suit—Will Travel", Url = "https://en.wikipedia.org/wiki/Have_Space_Suit%E2%80%94Will_Travel", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I Will Fear No Evil", Url = "https://en.wikipedia.org/wiki/I_Will_Fear_No_Evil", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "If This Goes On—", Url = "https://en.wikipedia.org/wiki/%22If_This_Goes_On%E2%80%94%22", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "If This Goes On—", Url = "https://archive.org/stream/Astounding_v24n06_1940-02_cape1736#page/n7/mode/2up", Label = "If This Goes On— part 1 on Archive.org", Description = "If This Goes On— on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "If This Goes On—", Url = "https://archive.org/stream/Astounding_v25n01_1940-03_AK#page/n115/mode/2up", Label = "If This Goes On— part 2 on Archive.org", Description = "If This Goes On— on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "It's Great to Be Back!", Url = "https://en.wikipedia.org/wiki/It%27s_Great_to_Be_Back!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jerry Was a Man", Url = "https://en.wikipedia.org/wiki/Jerry_Was_a_Man", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jerry Was a Man", Url = "https://www.youtube.com/watch?v=aJHiOiMKzX4&pp=ygUPamVycnkgd2FzIGEgbWFu", Label = "Masters of Science Fiction: Jerry Was a Man", Description = "Masters of Science Fiction: Jerry Was a Man", LinkType = LinkType.Video },
                new Link { BookTitle = "Job: A Comedy of Justice", Url = "https://en.wikipedia.org/wiki/Job:_A_Comedy_of_Justice", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Let There Be Light (Heinlein)", Url = "https://en.wikipedia.org/wiki/Let_There_Be_Light_(Heinlein_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Life-Line", Url = "https://en.wikipedia.org/wiki/Life-Line", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Life-Line", Url = "https://archive.org/details/Astounding_British_Ed._v01n01_1939-08/page/n59/mode/2up?view=theater", Label = "Life-Line on Archive.org", Description = "Life-Line on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Logic of Empire", Url = "https://en.wikipedia.org/wiki/Logic_of_Empire", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Long Watch", Url = "https://en.wikipedia.org/wiki/The_Long_Watch", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lost Legacy", Url = "https://en.wikipedia.org/wiki/Lost_Legacy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Magic, Inc.", Url = "https://en.wikipedia.org/wiki/Magic,_Inc.", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Man Who Sold the Moon (Collection)", Url = "https://en.wikipedia.org/wiki/The_Man_Who_Sold_the_Moon_(short_story_collection)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Man Who Traveled in Elephants", Url = "https://en.wikipedia.org/wiki/The_Man_Who_Traveled_in_Elephants", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Menace from Earth", Url = "https://en.wikipedia.org/wiki/The_Menace_from_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Methuselah's Children (Novel)", Url = "https://en.wikipedia.org/wiki/Methuselah%27s_Children", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Misfit", Url = "https://en.wikipedia.org/wiki/Misfit_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Misfit", Url = "https://archive.org/stream/Astounding_v24n03_1939-11_dtsg0318-LennyS#page/n51/mode/2up", Label = "Misfit on Archive.org", Description = "Misfit on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "The Moon Is a Harsh Mistress", Url = "https://en.wikipedia.org/wiki/The_Moon_Is_a_Harsh_Mistress", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "My Object All Sublime", Url = "https://en.wikipedia.org/wiki/My_Object_All_Sublime", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nothing Ever Happens on the Moon", Url = "https://en.wikipedia.org/wiki/Nothing_Ever_Happens_on_the_Moon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Number of the Beast", Url = "https://en.wikipedia.org/wiki/The_Number_of_the_Beast_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Ordeal in Space", Url = "https://en.wikipedia.org/wiki/Ordeal_in_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Orphans of the Sky", Url = "https://en.wikipedia.org/wiki/Orphans_of_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Our Fair City", Url = "https://en.wikipedia.org/wiki/Our_Fair_City", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Podkayne of Mars", Url = "https://en.wikipedia.org/wiki/Podkayne_of_Mars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Poor Daddy", Url = "https://en.wikipedia.org/wiki/Poor_Daddy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Project Nightmare", Url = "https://en.wikipedia.org/wiki/Project_Nightmare", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Puppet Masters", Url = "https://en.wikipedia.org/wiki/The_Puppet_Masters", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Pursuit of the Pankera", Url = "https://en.wikipedia.org/wiki/The_Number_of_the_Beast_(novel)#The_Pursuit_of_the_Pankera", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Red Planet", Url = "https://en.wikipedia.org/wiki/Red_Planet_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Red Planet", Url = "https://www.youtube.com/watch?v=i_GHFeXrRFY&list=PLVcyp7DP7MJxG2-QSUCi_Sqk2Xdzu1a7h", Label = "Red Planet (1994) Series on Youtube", Description = "Red Planet (1994) Series on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Roads Must Roll", Url = "https://en.wikipedia.org/wiki/The_Roads_Must_Roll", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Requiem", Url = "https://en.wikipedia.org/wiki/Requiem_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Requiem", Url = "https://archive.org/stream/Astounding_v24n05_1940-01_dtsg0318#page/n79/mode/2up", Label = "Requiem on Archive.org", Description = "Requiem on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Rocket Ship Galileo", Url = "https://en.wikipedia.org/wiki/Rocket_Ship_Galileo", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Rolling Stones", Url = "https://en.wikipedia.org/wiki/The_Rolling_Stones_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Searchlight", Url = "https://en.wikipedia.org/wiki/Searchlight_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sixth Column", Url = "https://en.wikipedia.org/wiki/Sixth_Column", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sky Lift", Url = "https://en.wikipedia.org/wiki/Sky_Lift", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Solution Unsatisfactory", Url = "https://en.wikipedia.org/wiki/Solution_Unsatisfactory", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Cadet", Url = "https://en.wikipedia.org/wiki/Space_Cadet", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Jockey", Url = "https://en.wikipedia.org/wiki/Space_Jockey", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Star Beast", Url = "https://en.wikipedia.org/wiki/The_Star_Beast_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Starman Jones", Url = "https://en.wikipedia.org/wiki/Starman_Jones", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Starship Troopers", Url = "https://en.wikipedia.org/wiki/Starship_Troopers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Stranger in a Strange Land", Url = "https://en.wikipedia.org/wiki/Stranger_in_a_Strange_Land", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Take Back Your Government: A Practical Handbook for the Private Citizen", Url = "https://en.wikipedia.org/wiki/Take_Back_Your_Government:_A_Practical_Handbook_for_the_Private_Citizen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Tenderfoot in Space", Url = "https://en.wikipedia.org/wiki/A_Tenderfoot_in_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "They", Url = "https://en.wikipedia.org/wiki/They_(Heinlein)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time Enough for Love", Url = "https://en.wikipedia.org/wiki/Time_Enough_for_Love", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time for the Stars", Url = "https://en.wikipedia.org/wiki/Time_for_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "To Sail Beyond the Sunset", Url = "https://en.wikipedia.org/wiki/To_Sail_Beyond_the_Sunset", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tomorrow, the Stars", Url = "https://en.wikipedia.org/wiki/Tomorrow,_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tramp Royale", Url = "https://en.wikipedia.org/wiki/Tramp_Royale", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tunnel in the Sky", Url = "https://en.wikipedia.org/wiki/Tunnel_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Unpleasant Profession of Jonathan Hoag", Url = "https://en.wikipedia.org/wiki/The_Unpleasant_Profession_of_Jonathan_Hoag", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Universe", Url = "https://www.youtube.com/watch?v=KtQvBwOx_W0", Label = "X Minus One - Universe", Description = "X Minus One - Universe on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Green Hills of Earth", Url = "https://www.youtube.com/watch?v=uoevtgzFIW0", Label = "X Minus One - The Green Hills of Earth", Description = "X Minus One - The Green Hills of Earth on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "Requiem", Url = "https://www.youtube.com/watch?v=Md6eFGYfP_w", Label = "X Minus One - Requiem", Description = "X Minus One - Requiem on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Roads Must Roll", Url = "https://www.youtube.com/watch?v=VYko6Zov3rA", Label = "X Minus One - The Roads Must Roll", Description = "X Minus One - The Roads Must Roll on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Green Hills of Earth", Url = "https://www.youtube.com/watch?v=wEpbXNEBxtI", Label = "Dimension X - The Green Hills of Earth", Description = "Dimension X - The Green Hills of Earth on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "Destination", Url = "https://www.youtube.com/watch?v=48lR6o2EN0s", Label = "Dimension X - Destination Moon", Description = "Dimension X - Destination Moon on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Roads Must Roll", Url = "https://www.youtube.com/watch?v=GRx8xxZ0gMM", Label = "Dimension X - The Roads Must Roll", Description = "Dimension X - The Roads Must Roll on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "Universe", Url = "https://www.youtube.com/watch?v=zT0QTyxlKWo", Label = "Dimension X - Universe", Description = "Dimension X - Universe on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "Requiem", Url = "https://www.youtube.com/watch?v=mQIfFj2eH7w", Label = "Dimension X - Requiem", Description = "Dimension X - Requiem on Youtube", LinkType = LinkType.Video },
                new Link { BookTitle = "Variable Star", Url = "https://en.wikipedia.org/wiki/Variable_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Waldo", Url = "https://en.wikipedia.org/wiki/Waldo_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Water Is for Washing", Url = "https://en.wikipedia.org/wiki/Water_Is_for_Washing", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "We Also Walk Dogs", Url = "https://en.wikipedia.org/wiki/%E2%80%94We_Also_Walk_Dogs", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Where To?", Url = "https://archive.org/stream/galaxymagazine-1952-02/Galaxy_1952_02#page/n13/mode/2up", Label = "Where To? (1952) on Archive.org", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Year of the Jackpot", Url = "https://en.wikipedia.org/wiki/The_Year_of_the_Jackpot", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                // Clarke
                new Link { BookTitle = "2001: A Space Odyssey", Url = "https://en.wikipedia.org/wiki/2001:_A_Space_Odyssey_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "2010: Odyssey Two", Url = "https://en.wikipedia.org/wiki/2010:_Odyssey_Two", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "2061: Odyssey Three", Url = "https://en.wikipedia.org/wiki/2061:_Odyssey_Three", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "3001: The Final Odyssey", Url = "https://en.wikipedia.org/wiki/3001:_The_Final_Odyssey", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rendezvous with Rama", Url = "https://en.wikipedia.org/wiki/Rendezvous_with_Rama", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rendezvous with Rama", Url = "https://en.wikipedia.org/wiki/Rendezvous_with_Rama_(video_game)", Label = "Rendezvous with Rama 1984 Video Game on Wikipedia", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rendezvous with Rama", Url = "https://en.wikipedia.org/wiki/Rama_(video_game)", Label = "1996 Rama Video Game on Wikipedia", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rama II", Url = "https://en.wikipedia.org/wiki/Rama_II_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Garden of Rama", Url = "https://en.wikipedia.org/wiki/The_Garden_of_Rama", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rama Revealed", Url = "https://en.wikipedia.org/wiki/Rama_Revealed", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time's Eye", Url = "https://en.wikipedia.org/wiki/Time%27s_Eye_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sunstorm", Url = "https://en.wikipedia.org/wiki/Sunstorm_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Firstborn", Url = "https://en.wikipedia.org/wiki/Firstborn_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Against the Fall of Night", Url = "https://en.wikipedia.org/wiki/Against_the_Fall_of_Night", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Prelude to Space", Url = "https://en.wikipedia.org/wiki/Prelude_to_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Sands of Mars", Url = "https://en.wikipedia.org/wiki/The_Sands_of_Mars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Islands in the Sky", Url = "https://en.wikipedia.org/wiki/Islands_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Childhood's End", Url = "https://en.wikipedia.org/wiki/Childhood%27s_End", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Childhood's End", Url = "https://en.wikipedia.org/wiki/Childhood%27s_End_(miniseries)", Label = "Miniseries on Wikipedia", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Earthlight (Novel)", Url = "https://en.wikipedia.org/wiki/Earthlight", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The City and the Stars", Url = "https://en.wikipedia.org/wiki/The_City_and_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Deep Range (Novel)", Url = "https://en.wikipedia.org/wiki/The_Deep_Range", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Fall of Moondust", Url = "https://en.wikipedia.org/wiki/A_Fall_of_Moondust", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Dolphin Island", Url = "https://en.wikipedia.org/wiki/Dolphin_Island_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Glide Path", Url = "https://en.wikipedia.org/wiki/Glide_Path", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Imperial Earth", Url = "https://en.wikipedia.org/wiki/Imperial_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Fountains of Paradise", Url = "https://en.wikipedia.org/wiki/The_Fountains_of_Paradise", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Songs of Distant Earth (Novel)", Url = "https://en.wikipedia.org/wiki/The_Songs_of_Distant_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Songs of Distant Earth (Novel)", Url = "https://en.wikipedia.org/wiki/The_Songs_of_Distant_Earth_(album)", Label = "Mike Oldfield concept album on Wikipedia", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Cradle", Url = "https://en.wikipedia.org/wiki/Cradle_(novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Beyond the Fall of Night", Url = "https://en.wikipedia.org/wiki/Beyond_the_Fall_of_Night", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Ghost from the Grand Banks", Url = "https://en.wikipedia.org/wiki/The_Ghost_from_the_Grand_Banks", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Hammer of God (Novel)", Url = "https://en.wikipedia.org/wiki/The_Hammer_of_God_(Clarke_novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Richter 10", Url = "https://en.wikipedia.org/wiki/Richter_10", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Trigger", Url = "https://en.wikipedia.org/wiki/The_Trigger", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Light of Other Days", Url = "https://en.wikipedia.org/wiki/The_Light_of_Other_Days", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Last Theorem", Url = "https://en.wikipedia.org/wiki/The_Last_Theorem", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Travel by Wire!", Url = "https://en.wikipedia.org/wiki/Travel_by_Wire!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "How We Went to Mars", Url = "https://en.wikipedia.org/wiki/How_We_Went_to_Mars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Awakening", Url = "https://en.wikipedia.org/wiki/The_Awakening_(Arthur_C_Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Lion of Comarre and Against the Fall of Night", Url = "https://en.wikipedia.org/wiki/The_Lion_of_Comarre_and_Against_the_Fall_of_Night", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Loophole", Url = "https://en.wikipedia.org/wiki/Loophole_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rescue Party", Url = "https://en.wikipedia.org/wiki/Rescue_Party_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Technical Error", Url = "https://en.wikipedia.org/wiki/Technical_Error", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Inheritance", Url = "https://en.wikipedia.org/wiki/Inheritance_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Exile of the Eons", Url = "https://en.wikipedia.org/wiki/Exile_of_the_Eons", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time's Arrow", Url = "https://en.wikipedia.org/wiki/Time%27s_Arrow_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Earthlight (Short Story)", Url = "https://en.wikipedia.org/wiki/Earthlight_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "If I Forget Thee, Oh Earth", Url = "https://en.wikipedia.org/wiki/If_I_Forget_Thee,_Oh_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Sentinel", Url = "https://en.wikipedia.org/wiki/The_Sentinel_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Superiority", Url = "https://en.wikipedia.org/wiki/Superiority_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Trouble with the Natives", Url = "https://en.wikipedia.org/wiki/Trouble_with_the_Natives", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Encounter in the Dawn", Url = "https://en.wikipedia.org/wiki/Encounter_in_the_Dawn", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jupiter Five", Url = "https://en.wikipedia.org/wiki/Jupiter_Five", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Nine Billion Names of God", Url = "https://en.wikipedia.org/wiki/The_Nine_Billion_Names_of_God", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Nine Billion Names of God", Url = "https://en.wikipedia.org/wiki/The_Nine_Billion_Names_of_God_(film)", Label = "Short Film on Wikipedia", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Nine Billion Names of God", Url = "https://www.youtube.com/watch?v=cet_hy4kq7k", Label = "Short Film Trailer on YouTube", LinkType = LinkType.Trailer },
                new Link { BookTitle = "The Possessed", Url = "https://en.wikipedia.org/wiki/The_Possessed_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Armaments Race", Url = "https://en.wikipedia.org/wiki/Armaments_Race", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Man Who Ploughed the Sea", Url = "https://en.wikipedia.org/wiki/The_Man_Who_Ploughed_the_Sea", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Patent Pending", Url = "https://en.wikipedia.org/wiki/Patent_Pending_(Arthur_C_Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Silence Please", Url = "https://en.wikipedia.org/wiki/Silence_Please", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Star", Url = "https://en.wikipedia.org/wiki/The_Star_(Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "What Goes Up", Url = "https://en.wikipedia.org/wiki/What_Goes_Up_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Big Game Hunt", Url = "https://en.wikipedia.org/wiki/Big_Game_Hunt", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Pacifist", Url = "https://en.wikipedia.org/wiki/The_Pacifist_(Arthur_C_Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Reluctant Orchid", Url = "https://en.wikipedia.org/wiki/The_Reluctant_Orchid", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Venture to the Moon", Url = "https://en.wikipedia.org/wiki/Venture_to_the_Moon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Cold War", Url = "https://en.wikipedia.org/wiki/Cold_War_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Critical Mass", Url = "https://en.wikipedia.org/wiki/Critical_Mass_(Arthur_C._Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Defenestration of Ermintrude Inch", Url = "https://en.wikipedia.org/wiki/The_Defenestration_of_Ermintrude_Inch", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Let There Be Light (Clarke)", Url = "https://en.wikipedia.org/wiki/Let_There_Be_Light_(Clarke_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Moving Spirit", Url = "https://en.wikipedia.org/wiki/Moving_Spirit", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Next Tenants", Url = "https://en.wikipedia.org/wiki/The_Next_Tenants", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Ultimate Melody", Url = "https://en.wikipedia.org/wiki/The_Ultimate_Melody", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Slight Case of Sunstroke", Url = "https://archive.org/stream/galaxymagazine-1958-09/Galaxy_1958_09#page/n71/mode/2up", Label = "A Slight Case of Sunstroke (1958) on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Out From the Sun", Url = "https://archive.org/stream/1958-02_IF#page/n59/mode/2up", Label = "Out From the Sun (1958) on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Into the Comet", Url = "https://en.wikipedia.org/wiki/Into_the_Comet", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I Remember Babylon", Url = "https://en.wikipedia.org/wiki/I_Remember_Babylon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Summertime on Icarus", Url = "https://en.wikipedia.org/wiki/Summertime_on_Icarus", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Before Eden", Url = "https://en.wikipedia.org/wiki/Before_Eden", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Death and the Senator", Url = "https://en.wikipedia.org/wiki/Death_and_the_Senator", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Food of the Gods", Url = "https://en.wikipedia.org/wiki/The_Food_of_the_Gods_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hate", Url = "https://en.wikipedia.org/wiki/Hate_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Saturn Rising", Url = "https://en.wikipedia.org/wiki/Saturn_Rising", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Dog Star", Url = "https://en.wikipedia.org/wiki/Dog_Star_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Secret", Url = "https://en.wikipedia.org/wiki/The_Secret_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sunjammer", Url = "https://en.wikipedia.org/wiki/Sunjammer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Longest Science Fiction Story Ever Told", Url = "https://archive.org/stream/Galaxy_v25n01_1966-10#page/n77/mode/2up", Label = "The Longest Science Fiction Story Ever Told (1966) on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Crusade", Url = "https://en.wikipedia.org/wiki/Crusade_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Neutron Tide", Url = "https://en.wikipedia.org/wiki/Neutron_Tide", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Meeting with Medusa", Url = "https://en.wikipedia.org/wiki/A_Meeting_with_Medusa", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "When the Twerms Came", Url = "https://en.wikipedia.org/wiki/When_the_Twerms_Came", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Improving the Neighbourhood", Url = "https://en.wikipedia.org/wiki/Improving_the_Neighbourhood", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                // Asimov
                new Link { BookTitle = ". . . That Thou Art Mindful of Him", Url = "https://en.wikipedia.org/wiki/._._._That_Thou_Art_Mindful_of_Him", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "2430 A.D.", Url = "https://en.wikipedia.org/wiki/2430_A.D.", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Boy's Best Friend", Url = "https://en.wikipedia.org/wiki/A_Boy%27s_Best_Friend", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Loint of Paw", Url = "https://en.wikipedia.org/wiki/A_Loint_of_Paw", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "A Statue for Father", Url = "https://en.wikipedia.org/wiki/A_Statue_for_Father", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Adding a Dimension", Url = "https://en.wikipedia.org/wiki/Adding_a_Dimension", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "All the Troubles of the World", Url = "https://en.wikipedia.org/wiki/All_the_Troubles_of_the_World", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Anniversary", Url = "https://en.wikipedia.org/wiki/Anniversary_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Asimov's Biographical Encyclopedia of Science and Technology", Url = "https://en.wikipedia.org/wiki/Asimov%27s_Biographical_Encyclopedia_of_Science_and_Technology", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Asimov's Chronology of the World", Url = "https://en.wikipedia.org/wiki/Asimov%27s_Chronology_of_the_World", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Asimov's Guide to Shakespeare", Url = "https://en.wikipedia.org/wiki/Asimov%27s_Guide_to_Shakespeare", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Asimov's Guide to the Bible", Url = "https://en.wikipedia.org/wiki/Asimov%27s_Guide_to_the_Bible", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Asimov's Mysteries", Url = "https://en.wikipedia.org/wiki/Asimov%27s_Mysteries", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Atlantis", Url = "https://en.wikipedia.org/wiki/Atlantis_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Atom: Journey Across the Subatomic Cosmos", Url = "https://en.wikipedia.org/wiki/Atom:_Journey_Across_the_Subatomic_Cosmos", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Author! Author!", Url = "https://en.wikipedia.org/wiki/Author!_Author!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Autobiographies of Isaac Asimov", Url = "https://en.wikipedia.org/wiki/Autobiographies_of_Isaac_Asimov", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Azazel", Url = "https://en.wikipedia.org/wiki/Azazel_(Asimov)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Banquets of the Black Widowers", Url = "https://en.wikipedia.org/wiki/Banquets_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Big Game", Url = "https://en.wikipedia.org/wiki/Big_Game_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Birth of a Notion", Url = "https://en.wikipedia.org/wiki/Birth_of_a_Notion_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Black Friar of the Flame", Url = "https://en.wikipedia.org/wiki/Black_Friar_of_the_Flame", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Blank!", Url = "https://en.wikipedia.org/wiki/Blank!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Blank!", Url = "https://en.wikipedia.org/wiki/Blank!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Blind Alley", Url = "https://en.wikipedia.org/wiki/Blind_Alley", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Breeds There a Man...?", Url = "https://en.wikipedia.org/wiki/Breeds_There_a_Man...%3F", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Button, Button", Url = "https://en.wikipedia.org/wiki/Button,_Button_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Buy Jupiter and Other Stories", Url = "https://en.wikipedia.org/wiki/Buy_Jupiter_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Buy Jupiter", Url = "https://en.wikipedia.org/wiki/Buy_Jupiter", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "C-Chute", Url = "https://en.wikipedia.org/wiki/C-Chute", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "C-Chute", Url = "https://www.youtube.com/watch?v=e1Z-4Rm12lk", Label = "C-Chute episode of X Minus One (1955) on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Cal", Url = "https://en.wikipedia.org/wiki/Cal_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Casebook of the Black Widowers", Url = "https://en.wikipedia.org/wiki/Casebook_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Catch That Rabbit", Url = "https://en.wikipedia.org/wiki/Catch_That_Rabbit", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Christmas on Ganymede", Url = "https://en.wikipedia.org/wiki/Christmas_on_Ganymede", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Comets", Url = "https://en.wikipedia.org/wiki/Comets_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Curses", Url = "https://en.wikipedia.org/wiki/Curses_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Darwinian Pool Room", Url = "https://en.wikipedia.org/wiki/Darwinian_Pool_Room", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Day of the Hunters", Url = "https://en.wikipedia.org/wiki/Day_of_the_Hunters", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Death Sentence", Url = "https://en.wikipedia.org/wiki/Death_Sentence_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Devils", Url = "https://en.wikipedia.org/wiki/Devils_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Does a Bee Care?", Url = "https://en.wikipedia.org/wiki/Does_a_Bee_Care%3F", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Dreaming Is a Private Thing", Url = "https://en.wikipedia.org/wiki/Dreaming_Is_a_Private_Thing", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Each an Explorer", Url = "https://en.wikipedia.org/wiki/Each_an_Explorer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Earth Is Room Enough", Url = "https://en.wikipedia.org/wiki/Earth_Is_Room_Enough", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Escape!", Url = "https://en.wikipedia.org/wiki/Escape!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Escape!", Url = "https://en.wikipedia.org/wiki/Escape!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Everest", Url = "https://en.wikipedia.org/wiki/Everest_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Evidence", Url = "https://en.wikipedia.org/wiki/Evidence_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Exile to Hell", Url = "https://en.wikipedia.org/wiki/Exile_to_Hell", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Exploring the Earth and the Cosmos", Url = "https://en.wikipedia.org/wiki/Exploring_the_Earth_and_the_Cosmos", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Extraterrestrial Civilizations", Url = "https://en.wikipedia.org/wiki/Extraterrestrial_Civilizations_(book)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Eyes Do More Than See", Url = "https://en.wikipedia.org/wiki/Eyes_Do_More_Than_See", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Fact and Fancy", Url = "https://en.wikipedia.org/wiki/Fact_and_Fancy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Faeries", Url = "https://en.wikipedia.org/wiki/Faeries_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Fantastic Voyage II: Destination Brain", Url = "https://en.wikipedia.org/wiki/Fantastic_Voyage_II:_Destination_Brain", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Feminine Intuition", Url = "https://en.wikipedia.org/wiki/Feminine_Intuition", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "First Law", Url = "https://en.wikipedia.org/wiki/First_Law", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Flies", Url = "https://en.wikipedia.org/wiki/Flies_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "For the Birds", Url = "https://en.wikipedia.org/wiki/For_the_Birds_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Forward the Foundation", Url = "https://en.wikipedia.org/wiki/Forward_the_Foundation", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Foundation and Earth", Url = "https://en.wikipedia.org/wiki/Foundation_and_Earth", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Foundation and Empire", Url = "https://en.wikipedia.org/wiki/Foundation_and_Empire", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Foundation", Url = "https://en.wikipedia.org/wiki/Foundation_(Isaac_Asimov_novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Foundation", Url = "https://www.youtube.com/watch?v=X4QYV5GTz7c", Label = "Foundation Apple Series Trailer on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Foundation", Url = "https://www.youtube.com/watch?v=d2nls_jN1hw", Label = "Foundation BBC Radio show on YouTube", LinkType = LinkType.Video },       
                new Link { BookTitle = "Foundation's Edge", Url = "https://en.wikipedia.org/wiki/Foundation%27s_Edge", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Founding Father", Url = "https://en.wikipedia.org/wiki/Founding_Father_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Franchise", Url = "https://en.wikipedia.org/wiki/Franchise_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "From Earth to Heaven", Url = "https://en.wikipedia.org/wiki/From_Earth_to_Heaven", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Galley Slave", Url = "https://en.wikipedia.org/wiki/Galley_Slave", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Getting Even", Url = "https://en.wikipedia.org/wiki/Getting_Even_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Ghosts", Url = "https://en.wikipedia.org/wiki/Ghosts_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Giants", Url = "https://en.wikipedia.org/wiki/Giants_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gimmicks Three", Url = "https://en.wikipedia.org/wiki/Gimmicks_Three", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gold (Collection)", Url = "https://en.wikipedia.org/wiki/Gold_(Asimov_book)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Gold", Url = "https://en.wikipedia.org/wiki/Gold_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Good Taste (Short Story)", Url = "https://en.wikipedia.org/wiki/Good_Taste", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Green Patches", Url = "https://en.wikipedia.org/wiki/Green_Patches", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Half-Breed", Url = "https://en.wikipedia.org/wiki/Half-Breed_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Half-Breeds of Venus", Url = "https://en.wikipedia.org/wiki/Half-Breeds_of_Venus", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hallucination", Url = "https://en.wikipedia.org/wiki/Hallucination_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hell-Fire", Url = "https://en.wikipedia.org/wiki/Hell-Fire", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Heredity", Url = "https://en.wikipedia.org/wiki/Heredity_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "History", Url = "https://en.wikipedia.org/wiki/History_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Homo Sol", Url = "https://en.wikipedia.org/wiki/Homo_Sol", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hostess", Url = "https://en.wikipedia.org/wiki/Hostess_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hostess", Url = "https://www.youtube.com/watch?v=vOcpN3l3KRc ", Label = "Hostess episode of X Minus One (1955) on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "I Just Make Them Up, See!", Url = "https://en.wikipedia.org/wiki/I_Just_Make_Them_Up,_See!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I'm in Marsport Without Hilda", Url = "https://en.wikipedia.org/wiki/I%27m_in_Marsport_Without_Hilda", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I, Robot", Url = "https://en.wikipedia.org/wiki/I,_Robot", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "I, Robot", Url = "https://www.youtube.com/watch?v=IxqE12a0IHU", Label = "I, Robot radio drama by BBC Radio on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "In Memory Yet Green", Url = "https://en.wikipedia.org/wiki/In_Memory_Yet_Green", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "In a Good Cause—", Url = "https://en.wikipedia.org/wiki/In_a_Good_Cause%E2%80%94", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Insert Knob A in Hole B", Url = "https://en.wikipedia.org/wiki/Insert_Knob_A_in_Hole_B", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Inside the Atom", Url = "https://en.wikipedia.org/wiki/Inside_the_Atom", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Intergalactic Empires", Url = "https://en.wikipedia.org/wiki/Intergalactic_Empires", Label = "Wikipedia Link", LinkType = LinkType.Wiki },  
                new Link { BookTitle = "Invasions", Url = "https://en.wikipedia.org/wiki/Invasions_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Isaac Asimov's Guide to Earth and Space", Url = "https://en.wikipedia.org/wiki/Isaac_Asimov%27s_Guide_to_Earth_and_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Isaac Asimov's Treasury of Humor", Url = "https://en.wikipedia.org/wiki/Isaac_Asimov%27s_Treasury_of_Humor", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "It's Such a Beautiful Day", Url = "https://en.wikipedia.org/wiki/It%27s_Such_a_Beautiful_Day_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Jokester", Url = "https://en.wikipedia.org/wiki/Jokester", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Key Item", Url = "https://en.wikipedia.org/wiki/Key_Item", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Kid Stuff", Url = "https://en.wikipedia.org/wiki/Kid_Stuff", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lecherous Limericks", Url = "https://en.wikipedia.org/wiki/Lecherous_Limericks", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Legal Rites", Url = "https://en.wikipedia.org/wiki/Legal_Rites", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lenny", Url = "https://en.wikipedia.org/wiki/Lenny_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lest We Remember", Url = "https://en.wikipedia.org/wiki/Lest_We_Remember", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Let's Get Together", Url = "https://en.wikipedia.org/wiki/Let%27s_Get_Together_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Let's Not", Url = "https://en.wikipedia.org/wiki/Let%27s_Not", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Liar!", Url = "https://en.wikipedia.org/wiki/Liar!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Liar!", Url = "https://web.archive.org/web/20111006205603/http://randysoldtimeradioshows.com/drive1/E%20Shows/Exploring%20Tomorrow/58-02-26%20Exploring%20Tomorrow%20(12)%20The%20Liar.mp3", Label = "Liar! episode of Exploring Tomorrow on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Liar!", Url = "https://www.youtube.com/watch?v=2OQumv6UO1g", Label = "Liar! episode of Exploring Tomorrow on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Light Verse", Url = "https://en.wikipedia.org/wiki/Light_Verse_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Little Lost Robot", Url = "https://en.wikipedia.org/wiki/Little_Lost_Robot", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Little Lost Robot", Url = "https://www.youtube.com/watch?v=I-RX1GT4GT0", Label = "'Little Lost Robot' episode of 'Out of This World' on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Living Space", Url = "https://en.wikipedia.org/wiki/Living_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lucky Starr and the Big Sun of Mercury", Url = "https://en.wikipedia.org/wiki/Lucky_Starr_and_the_Big_Sun_of_Mercury", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lucky Starr and the Moons of Jupiter", Url = "https://en.wikipedia.org/wiki/Lucky_Starr_and_the_Moons_of_Jupiter", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lucky Starr and the Oceans of Venus", Url = "https://en.wikipedia.org/wiki/Lucky_Starr_and_the_Oceans_of_Venus", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lucky Starr and the Pirates of the Asteroids", Url = "https://en.wikipedia.org/wiki/Lucky_Starr_and_the_Pirates_of_the_Asteroids", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Lucky Starr and the Rings of Saturn", Url = "https://en.wikipedia.org/wiki/Lucky_Starr_and_the_Rings_of_Saturn", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Magic", Url = "https://en.wikipedia.org/wiki/Magic_(short_story_collection)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Magical Wishes", Url = "https://en.wikipedia.org/wiki/Magical_Wishes", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Marching In", Url = "https://en.wikipedia.org/wiki/Marching_In", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Marooned off Vesta", Url = "https://en.wikipedia.org/wiki/Marooned_off_Vesta", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Mirror Image", Url = "https://en.wikipedia.org/wiki/Mirror_Image_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Monsters", Url = "https://en.wikipedia.org/wiki/Monsters_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "More Tales of the Black Widowers", Url = "https://en.wikipedia.org/wiki/More_Tales_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Mother Earth", Url = "https://en.wikipedia.org/wiki/Mother_Earth_(novella)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Murder at the ABA", Url = "https://en.wikipedia.org/wiki/Murder_at_the_ABA", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "My Son, the Physicist", Url = "https://en.wikipedia.org/wiki/My_Son,_the_Physicist", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Mythical Beasties", Url = "https://en.wikipedia.org/wiki/Mythical_Beasties", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nemesis", Url = "https://en.wikipedia.org/wiki/Nemesis_(Asimov)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nightfall and Other Stories", Url = "https://en.wikipedia.org/wiki/Nightfall_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nightfall", Url = "https://en.wikipedia.org/wiki/Nightfall_(Asimov_novelette_and_novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nightfall", Url = "https://en.wikipedia.org/wiki/Nightfall_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nightfall", Url = "https://en.wikipedia.org/wiki/Nightfall_(Asimov_short_story_and_novel)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Nightfall", Url = "https://www.youtube.com/watch?v=_iRkd6_kM00", Label = "Nightfall episode of Dimension X (1951) on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Nightfall", Url = "https://www.youtube.com/watch?v=KKwm0ux0ATg", Label = "Nightfall episode of X Minus One (1955) on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Nine Tomorrows", Url = "https://en.wikipedia.org/wiki/Nine_Tomorrows", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "No Connection", Url = "https://en.wikipedia.org/wiki/No_Connection", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "No Refuge Could Save", Url = "https://en.wikipedia.org/wiki/No_Refuge_Could_Save", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Norby, the Mixed-up Robot", Url = "https://en.wikipedia.org/wiki/Norby,_the_Mixed-up_Robot", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Not Final!", Url = "https://en.wikipedia.org/wiki/Not_Final!", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Not Final!", Url = "https://en.wikipedia.org/wiki/Not_Final!_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Obituary", Url = "https://en.wikipedia.org/wiki/Obituary_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Of Time and Space and Other Things", Url = "https://en.wikipedia.org/wiki/Of_Time_and_Space_and_Other_Things", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Old-fashioned", Url = "https://en.wikipedia.org/wiki/Old-fashioned_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Only a Trillion", Url = "https://en.wikipedia.org/wiki/Only_a_Trillion", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Opus 100", Url = "https://en.wikipedia.org/wiki/Opus_100", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Opus 200", Url = "https://en.wikipedia.org/wiki/Opus_200", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Our Angry Earth: A Ticking Ecological Bomb", Url = "https://en.wikipedia.org/wiki/Our_Angry_Earth:_A_Ticking_Ecological_Bomb", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Out of the Everywhere", Url = "https://en.wikipedia.org/wiki/Out_of_the_Everywhere", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Pebble in the Sky", Url = "https://en.wikipedia.org/wiki/Pebble_in_the_Sky", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Pebble in the Sky", Url = "https://www.youtube.com/watch?v=wtVDRiksN8s", Label = "Pebble in the Sky episode of Dimension X on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "Ph as in Phony", Url = "https://en.wikipedia.org/wiki/Ph_as_in_Phony", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Point of View", Url = "https://en.wikipedia.org/wiki/Point_of_View_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Prelude to Foundation", Url = "https://en.wikipedia.org/wiki/Prelude_to_Foundation", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Profession", Url = "https://en.wikipedia.org/wiki/Profession_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Puzzles of the Black Widowers", Url = "https://en.wikipedia.org/wiki/Puzzles_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Pâté de Foie Gras", Url = "https://en.wikipedia.org/wiki/P%C3%A2t%C3%A9_de_Foie_Gras_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Question", Url = "https://en.wikipedia.org/wiki/Question_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rain, Rain, Go Away", Url = "https://en.wikipedia.org/wiki/Rain,_Rain,_Go_Away_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Reason", Url = "https://en.wikipedia.org/wiki/Reason_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Rejection Slips", Url = "https://en.wikipedia.org/wiki/Rejection_Slips", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Ring Around the Sun", Url = "https://en.wikipedia.org/wiki/Ring_Around_the_Sun_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Risk", Url = "https://en.wikipedia.org/wiki/Risk_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robbie", Url = "https://en.wikipedia.org/wiki/Robbie_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robot AL-76 Goes Astray", Url = "https://en.wikipedia.org/wiki/Robot_AL-76_Goes_Astray", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robot Dreams", Url = "https://en.wikipedia.org/wiki/Robot_Dreams_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robot Visions", Url = "https://en.wikipedia.org/wiki/Robot_Visions", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robots and Empire", Url = "https://en.wikipedia.org/wiki/Robots_and_Empire", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Robots", Url = "https://en.wikipedia.org/wiki/Robots_(Asimov_anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Runaround", Url = "https://en.wikipedia.org/wiki/Runaround_(story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sally", Url = "https://en.wikipedia.org/wiki/Sally_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Satisfaction Guaranteed", Url = "https://en.wikipedia.org/wiki/Satisfaction_Guaranteed_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Science Fiction A to Z", Url = "https://en.wikipedia.org/wiki/Science_Fiction_A_to_Z", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Science Fiction by Asimov", Url = "https://en.wikipedia.org/wiki/Science_Fiction_by_Asimov", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Science, Numbers, and I", Url = "https://en.wikipedia.org/wiki/Science,_Numbers,_and_I", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Second Foundation", Url = "https://en.wikipedia.org/wiki/Second_Foundation", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Segregationist", Url = "https://en.wikipedia.org/wiki/Segregationist_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Shah Guido G.", Url = "https://en.wikipedia.org/wiki/Shah_Guido_G.", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Silly Asses", Url = "https://en.wikipedia.org/wiki/Silly_Asses", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sixty Million Trillion Combinations", Url = "https://en.wikipedia.org/wiki/Sixty_Million_Trillion_Combinations", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Someday", Url = "https://en.wikipedia.org/wiki/Someday_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Mail", Url = "https://en.wikipedia.org/wiki/Space_Mail", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Space Shuttles", Url = "https://en.wikipedia.org/wiki/Space_Shuttles_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Spell My Name with an S", Url = "https://en.wikipedia.org/wiki/Spell_My_Name_with_an_S", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Spells", Url = "https://en.wikipedia.org/wiki/Spells_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Star Light", Url = "https://en.wikipedia.org/wiki/Star_Light_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Stranger in Paradise", Url = "https://en.wikipedia.org/wiki/Stranger_in_Paradise_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Strikebreaker", Url = "https://en.wikipedia.org/wiki/Strikebreaker_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Sucker Bait", Url = "https://en.wikipedia.org/wiki/Sucker_Bait", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Super-Neutron", Url = "https://en.wikipedia.org/wiki/Super-Neutron", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Supermen", Url = "https://en.wikipedia.org/wiki/Supermen_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Take a Match", Url = "https://en.wikipedia.org/wiki/Take_a_Match", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tales of the Black Widowers", Url = "https://en.wikipedia.org/wiki/Tales_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Acquisitive Chuckle", Url = "https://en.wikipedia.org/wiki/The_Acquisitive_Chuckle", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Alternate Asimovs", Url = "https://en.wikipedia.org/wiki/The_Alternate_Asimovs", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Asimov Chronicles", Url = "https://en.wikipedia.org/wiki/The_Asimov_Chronicles:_Fifty_Years_of_Isaac_Asimov", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Author's Ordeal", Url = "https://en.wikipedia.org/wiki/The_Author%27s_Ordeal", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Best Mysteries of Isaac Asimov", Url = "https://en.wikipedia.org/wiki/The_Best_Mysteries_of_Isaac_Asimov", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Bicentennial Man and Other Stories", Url = "https://en.wikipedia.org/wiki/The_Bicentennial_Man_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Bicentennial Man", Url = "https://en.wikipedia.org/wiki/The_Bicentennial_Man", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Bicentennial Man", Url = "https://www.youtube.com/watch?v=yfDlQ-Q12rg", Label = "The Bicentennial Man trailer on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Bicentennial Man", Url = "https://www.youtube.com/watch?v=aGM8FfdsByc", Label = "The Bicentennial Man full movie on YouTube", LinkType = LinkType.Video },
                new Link { BookTitle = "The Billiard Ball", Url = "https://en.wikipedia.org/wiki/The_Billiard_Ball", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Callistan Menace", Url = "https://en.wikipedia.org/wiki/The_Callistan_Menace", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Caves of Steel", Url = "https://en.wikipedia.org/wiki/The_Caves_of_Steel", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Complete Robot", Url = "https://en.wikipedia.org/wiki/The_Complete_Robot", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Complete Stories, Volume 1", Url = "https://en.wikipedia.org/wiki/The_Complete_Stories,_Volume_1", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Complete Stories, Volume 2", Url = "https://en.wikipedia.org/wiki/The_Complete_Stories,_Volume_2", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Complete Stories, Volume 3", Url = "https://en.wikipedia.org/wiki/The_Complete_Stories,_Volume_3", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Currents of Space", Url = "https://en.wikipedia.org/wiki/The_Currents_of_Space", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Dead Past", Url = "https://en.wikipedia.org/wiki/The_Dead_Past", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Death Dealers", Url = "https://en.wikipedia.org/wiki/The_Death_Dealers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Deep", Url = "https://en.wikipedia.org/wiki/The_Deep_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Disappearing Man and Other Mysteries", Url = "https://en.wikipedia.org/wiki/The_Disappearing_Man_and_Other_Mysteries", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Dust of Death", Url = "https://en.wikipedia.org/wiki/The_Dust_of_Death", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Dying Night", Url = "https://en.wikipedia.org/wiki/The_Dying_Night", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Early Asimov", Url = "https://en.wikipedia.org/wiki/The_Early_Asimov", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Edge of Tomorrow", Url = "https://en.wikipedia.org/wiki/The_Edge_of_Tomorrow_(Asimov_book)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Endochronic Properties of Resublimated Thiotimoline", Url = "https://en.wikipedia.org/wiki/Thiotimoline", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Evitable Conflict", Url = "https://en.wikipedia.org/wiki/The_Evitable_Conflict", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Feeling of Power", Url = "https://en.wikipedia.org/wiki/The_Feeling_of_Power", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Foundation of S.F. Success", Url = "https://en.wikipedia.org/wiki/The_Foundation_of_S.F._Success", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Fun They Had", Url = "https://en.wikipedia.org/wiki/The_Fun_They_Had", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Gentle Vultures", Url = "https://en.wikipedia.org/wiki/The_Gentle_Vultures", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Gods Themselves", Url = "https://en.wikipedia.org/wiki/The_Gods_Themselves", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Greatest Asset", Url = "https://en.wikipedia.org/wiki/The_Greatest_Asset", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Hazing", Url = "https://en.wikipedia.org/wiki/The_Hazing", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Imaginary", Url = "https://en.wikipedia.org/wiki/The_Imaginary_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Immortal Bard", Url = "https://en.wikipedia.org/wiki/The_Immortal_Bard", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Instability", Url = "https://en.wikipedia.org/wiki/The_Instability", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Intelligent Man's Guide to Science", Url = "https://en.wikipedia.org/wiki/The_Intelligent_Man%27s_Guide_to_Science", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Key Word and Other Mysteries", Url = "https://en.wikipedia.org/wiki/The_Key_Word_and_Other_Mysteries", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Key", Url = "https://en.wikipedia.org/wiki/The_Key_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Last Answer", Url = "https://en.wikipedia.org/wiki/The_Last_Answer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Last Question", Url = "https://en.wikipedia.org/wiki/The_Last_Question", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Last Trump", Url = "https://en.wikipedia.org/wiki/The_Last_Trump", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Life and Times of Multivac", Url = "https://en.wikipedia.org/wiki/The_Life_and_Times_of_Multivac", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Little Man on the Subway", Url = "https://en.wikipedia.org/wiki/The_Little_Man_on_the_Subway", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Machine That Won the War", Url = "https://en.wikipedia.org/wiki/The_Machine_That_Won_the_War_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Magnificent Possession", Url = "https://en.wikipedia.org/wiki/The_Magnificent_Possession", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The March of the Millennia", Url = "https://en.wikipedia.org/wiki/The_March_of_the_Millennia", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Martian Way and Other Stories", Url = "https://en.wikipedia.org/wiki/The_Martian_Way_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Martian Way", Url = "https://en.wikipedia.org/wiki/The_Martian_Way", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Message", Url = "https://en.wikipedia.org/wiki/The_Message_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Micropsychiatric Applications of Thiotimoline", Url = "https://en.wikipedia.org/wiki/The_Micropsychiatric_Applications_of_Thiotimoline", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Micropsychiatric Applications of Thiotimoline", Url = "https://en.wikipedia.org/wiki/Thiotimoline", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Naked Sun", Url = "https://en.wikipedia.org/wiki/The_Naked_Sun", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The New Hugo Winners", Url = "https://en.wikipedia.org/wiki/The_New_Hugo_Winners", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Pause", Url = "https://en.wikipedia.org/wiki/The_Pause_(story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Planet That Wasn't", Url = "https://en.wikipedia.org/wiki/The_Planet_That_Wasn%27t", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Portable Star", Url = "https://en.wikipedia.org/wiki/The_Portable_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Positronic Man", Url = "https://en.wikipedia.org/wiki/The_Positronic_Man", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Proper Study", Url = "https://en.wikipedia.org/wiki/The_Proper_Study", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Red Queen's Race", Url = "https://en.wikipedia.org/wiki/The_Red_Queen%27s_Race", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Relativity of Wrong", Url = "https://en.wikipedia.org/wiki/The_Relativity_of_Wrong", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Rest of the Robots", Url = "https://en.wikipedia.org/wiki/The_Rest_of_the_Robots", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Return of the Black Widowers", Url = "https://en.wikipedia.org/wiki/The_Return_of_the_Black_Widowers", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Road to Infinity", Url = "https://en.wikipedia.org/wiki/The_Road_to_Infinity", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Robots of Dawn", Url = "https://en.wikipedia.org/wiki/The_Robots_of_Dawn", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Science Fictional Olympics", Url = "https://en.wikipedia.org/wiki/The_Science_Fictional_Olympics", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Secret Sense", Url = "https://en.wikipedia.org/wiki/The_Secret_Sense", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Secret of the Universe", Url = "https://en.wikipedia.org/wiki/The_Secret_of_the_Universe", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Singing Bell", Url = "https://en.wikipedia.org/wiki/The_Singing_Bell", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Subatomic Monster", Url = "https://en.wikipedia.org/wiki/The_Subatomic_Monster", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Sun Shines Bright", Url = "https://en.wikipedia.org/wiki/The_Sun_Shines_Bright_(book)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Talking Stone", Url = "https://en.wikipedia.org/wiki/The_Talking_Stone", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Tercentenary Incident", Url = "https://en.wikipedia.org/wiki/The_Tercentenary_Incident", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Tragedy of the Moon", Url = "https://en.wikipedia.org/wiki/The_Tragedy_of_the_Moon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Ugly Little Boy (Short Story)", Url = "https://en.wikipedia.org/wiki/The_Ugly_Little_Boy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Ultimate Crime", Url = "https://en.wikipedia.org/wiki/The_Ultimate_Crime", Label = "Wikipedia Link", LinkType = LinkType.Wiki },    
                new Link { BookTitle = "The Union Club Mysteries", Url = "https://en.wikipedia.org/wiki/The_Union_Club_Mysteries", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Up-to-Date Sorcerer", Url = "https://en.wikipedia.org/wiki/The_Up-to-Date_Sorcerer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Watery Place", Url = "https://en.wikipedia.org/wiki/The_Watery_Place", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Weapon Too Dreadful to Use", Url = "https://en.wikipedia.org/wiki/The_Weapon_Too_Dreadful_to_Use", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Weapon", Url = "https://en.wikipedia.org/wiki/The_Weapon_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Winds of Change and Other Stories", Url = "https://en.wikipedia.org/wiki/The_Winds_of_Change_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Winds of Change", Url = "https://en.wikipedia.org/wiki/The_Winds_of_Change_and_Other_Stories", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Winnowing", Url = "https://en.wikipedia.org/wiki/The_Winnowing", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Think!", Url = "https://en.wikipedia.org/wiki/Think!_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Thiotimoline and the Space Age", Url = "https://en.wikipedia.org/wiki/Thiotimoline", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Thiotimoline and the Space Age", Url = "https://en.wikipedia.org/wiki/Thiotimoline_and_the_Space_Age", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Thiotimoline to the Stars", Url = "https://en.wikipedia.org/wiki/Thiotimoline", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Thiotimoline to the Stars", Url = "https://en.wikipedia.org/wiki/Thiotimoline_to_the_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Through a Glass, Clearly", Url = "https://en.wikipedia.org/wiki/Through_a_Glass,_Clearly", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Time Pussy", Url = "https://en.wikipedia.org/wiki/Time_Pussy", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tin Stars", Url = "https://en.wikipedia.org/wiki/Tin_Stars", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Trends", Url = "https://en.wikipedia.org/wiki/Trends_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "True Love", Url = "https://en.wikipedia.org/wiki/True_Love_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Truth to Tell", Url = "https://en.wikipedia.org/wiki/Truth_to_Tell", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Understanding Physics", Url = "https://en.wikipedia.org/wiki/Understanding_Physics", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Unto the Fourth Generation", Url = "https://en.wikipedia.org/wiki/Unto_the_Fourth_Generation", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Victory Unintentional", Url = "https://en.wikipedia.org/wiki/Victory_Unintentional", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "View from a Height", Url = "https://en.wikipedia.org/wiki/View_from_a_Height", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Visions of the Universe", Url = "https://en.wikipedia.org/wiki/Visions_of_the_Universe", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Waterclap", Url = "https://en.wikipedia.org/wiki/Waterclap", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "What If—", Url = "https://en.wikipedia.org/wiki/What_If%E2%80%94", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "What Is This Thing Called Love?", Url = "https://en.wikipedia.org/wiki/What_is_This_Thing_Called_Love%3F_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "What's in a Name?", Url = "https://en.wikipedia.org/wiki/What%27s_in_a_Name%3F_(short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Where Is He?", Url = "https://en.wikipedia.org/wiki/Where_Is_He%3F", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Witches", Url = "https://en.wikipedia.org/wiki/Witches_(anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Wizards", Url = "https://en.wikipedia.org/wiki/Wizards_(Asimov_anthology)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Youth", Url = "https://en.wikipedia.org/wiki/Youth_(Asimov_short_story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Tower of Babylon", Url = "https://en.wikipedia.org/wiki/Tower_of_Babylon", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Division by Zero", Url = "https://en.wikipedia.org/wiki/Division_by_Zero", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Understand", Url = "https://en.wikipedia.org/wiki/Understand", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Story of Your Life", Url = "https://en.wikipedia.org/wiki/Story_of_Your_Life", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Evolution of Human Science", Url = "https://en.wikipedia.org/wiki/The_Evolution_of_Human_Science", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Seventy-Two Letters", Url = "https://en.wikipedia.org/wiki/Seventy-Two_Letters", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hell Is the Absence of God", Url = "https://en.wikipedia.org/wiki/Hell_Is_the_Absence_of_God", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Hell Is the Absence of God", Url = "https://thoughtcrime.crummy.com/2009/Error.html", Label = "Single-Bit Error by Ken Liu, a response/sequel to Hell Is the Absence of God", LinkType = LinkType.Download },
                new Link { BookTitle = "Liking What You See: A Documentary", Url = "https://en.wikipedia.org/wiki/Liking_What_You_See:_A_Documentary", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "What's Expected of Us", Url = "https://en.wikipedia.org/wiki/What%27s_Expected_of_Us", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Merchant and the Alchemist's Gate", Url = "https://en.wikipedia.org/wiki/The_Merchant_and_the_Alchemist%27s_Gate", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Exhalation", Url = "https://en.wikipedia.org/wiki/Exhalation", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Lifecycle of Software Objects", Url = "https://en.wikipedia.org/wiki/The_Lifecycle_of_Software_Objects", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Dacey's Patent Automatic Nanny", Url = "https://en.wikipedia.org/wiki/Dacey%27s_Patent_Automatic_Nanny", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Truth of Fact, the Truth of Feeling", Url = "https://en.wikipedia.org/wiki/The_Truth_of_Fact,_the_Truth_of_Feeling", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Great Silence", Url = "https://en.wikipedia.org/wiki/The_Great_Silence", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Omphalos", Url = "https://en.wikipedia.org/wiki/Omphalos", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Anxiety Is the Dizziness of Freedom", Url = "https://en.wikipedia.org/wiki/Anxiety_Is_the_Dizziness_of_Freedom", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "It's 2059, and the Rich Kids are Still Winning", Url = "https://en.wikipedia.org/wiki/It%27s_2059,_and_the_Rich_Kids_are_Still_Winning", Label = "Wikipedia Link", LinkType = LinkType.Wiki },             
                new Link { BookTitle = "It's 2059, and the Rich Kids are Still Winning", Url = "https://web.archive.org/web/20190601030957/https://www.nytimes.com/2019/05/27/opinion/ted-chiang-future-genetic-engineering.html", Label = "It's 2059, and the Rich Kids are Still Winning on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Frankenstein's Daughter by Maureen McHugh: An Appreciation", Url = "https://edsfproject.blogspot.com/2005/12/frankensteins-daughter-by-maureen.html", Label = "Frankenstein's Daughter by Maureen McHugh: An Appreciation on EdsfProject.blogspot.com", LinkType = LinkType.Download },
                new Link { BookTitle = "Introduction to Particle Theory", Url = "http://strangehorizons.com/fiction/introduction-to-particle-theory/", Label = "Introduction to Particle Theory on StrangeHorizons.com", LinkType = LinkType.Download },
                new Link { BookTitle = "If Chinese Were Phonetic", Url = "https://web.archive.org/web/20160601190340/https://www.newyorker.com/magazine/2016/05/16/if-chinese-were-phonetic", Label = "If Chinese Were Phonetic on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Silicon Valley Is Turning Into Its Own Worst Fear", Url = "https://web.archive.org/web/20180729193238/https://www.buzzfeednews.com/article/tedchiang/the-real-danger-to-civilization-isnt-ai-its-runaway", Label = "Silicon Valley Is Turning Into Its Own Worst Fear on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "What If Parents Loved Strangers' Children As Much As Their Own?", Url = "https://web.archive.org/web/20220721062024/https://www.newyorker.com/tech/annals-of-technology/what-if-parents-loved-strangers-children-as-much-as-their-own", Label = "What If Parents Loved Strangers' Children As Much As Their Own on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Why Computers Won't Make Themselves Smarter", Url = "https://web.archive.org/web/20210331161611/https://www.newyorker.com/culture/annals-of-inquiry/why-computers-wont-make-themselves-smarter", Label = "Why Computers Won't Make Themselves Smarter on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "ChatGPT Is a Blurry JPEG of the Web", Url = "https://web.archive.org/web/20251213234718/https://www.newyorker.com/tech/annals-of-technology/chatgpt-is-a-blurry-jpeg-of-the-web", Label = "ChatGPT Is a Blurry JPEG of the Web on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Will AI Become the New McKinsey?", Url = "https://web.archive.org/web/20251217111646/https://www.newyorker.com/science/annals-of-artificial-intelligence/will-ai-become-the-new-mckinsey", Label = "Will AI Become the New McKinsey? on Archive.org", LinkType = LinkType.Download },
                new Link { BookTitle = "Why A.I. Isn't Going to Make Art", Url = "https://web.archive.org/web/20240901011514/https://www.newyorker.com/culture/the-weekend-essay/why-ai-isnt-going-to-make-art", Label = "Why A.I. Isn't Going to Make Art on Archive.org", LinkType = LinkType.Download },
            };

            return (books, links);
        }
    }
}
