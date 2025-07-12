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
                    Title = "And He Built a Crooked House",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Type = BookType.ShortStory,
                    Description = "2016 Hugo Award (Retro Hugos: Novelette): Nominated",
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
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" }
                    }
                },
                new Book
                {
                    Title = "Coventry",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "2016 Hugo Award (Retro Hugos: Novella): Nominated, 2017 Prometheus Award (Hall of Fame Award): Won",
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
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Elsewhere",
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
                    Type = BookType.ShortStory,
                    Description = "2018 Hugo Award (Retro Hugos: Novelette): Nominated",
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
                    Description = "Posthumous Autobiography, 1990 Locus Award (Non-Fiction): Won, 1990 Hugo Award (Best Related Work): Nominated"
                },
                new Book
                {
                    Title = "Gulf",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1949,
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Type = BookType.ShortStory,
                    Description = "First novel, 2016 Hugo Award (Retro Hugos: Novella): Won",
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
                    Type = BookType.ShortStory,
                    Description = "Made for TV as episode 3 of 'Masters of Science Fiction'.",
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
                    Type = BookType.ShortStory,
                    Description = "",
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
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "a.k.a. Lost Legion",
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
                    Title = "Methuselah's Children",
                    Author = "Robert A. Heinlein",  
                    PublicationYear = 1941,
                    Type = BookType.ShortStory,
                    Description = "Lengthened and published as a novel in 1958",
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
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Type = BookType.ShortStory,
                    Description = "Heinlein did not include this story in any collections during his lifetime",
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
                    Title = "Orphans of the Sky",
                    Author = "Robert A. Heinlein",
                    PublicationYear = 1963,
                    Type = BookType.Novel,
                    Description = "Fix-up novel comprising the novellas Universe and Common Sense, both originally published in 1941"
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
                        new Tag { Name = "World as Myth" }
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
                    Type = BookType.ShortStory,
                    Description = "Won the 2003 Prometheus Award (Hall of Fame Award) and was nominated for the 2016 Retro Hugo Award for Short Story",
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
                    PublicationYear = 1940,
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Description = "a.k.a. Heil!",
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
                    Type = BookType.ShortStory,
                    Description = "",
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
                    Description = "Heinlein's travelogue from travelling in the 50s."
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
                    Type = BookType.ShortStory,
                    Description = "",
                    Tags = new List<Tag>
                    {
                        new Tag { Name = "Adapted for Radio" },
                        new Tag { Name = "Future History" },
                        new Tag { Name = "Collection: Off The Main Sequence" },
                        new Tag { Name = "Collection: The Past Through Tomorrow" }
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
                    Title = "Nightfall",
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





            };


            var links = new List<Link>
            {
                new Link { BookTitle = "A Bathroom of Her Own", Url = "https://en.wikipedia.org/wiki/A_Bathroom_of_Her_Own", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "All You Zombies", Url = "https://en.wikipedia.org/wiki/%27%E2%80%94All_You_Zombies%E2%80%94%27", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "And He Built a Crooked House", Url = "https://en.wikipedia.org/wiki/And_He_Built_a_Crooked_House", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
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
                new Link { BookTitle = "Delilah and the Space Rigger", Url = "https://en.wikipedia.org/wiki/Delilah_and_the_Space_Rigger", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Destination Moon", Url = "https://en.wikipedia.org/wiki/Destination_Moon_(story)", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "The Door into Summer", Url = "https://en.wikipedia.org/wiki/The_Door_into_Summer", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Double Star", Url = "https://en.wikipedia.org/wiki/Double_Star", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
                new Link { BookTitle = "Elsewhen", Url = "https://en.wikipedia.org/wiki/Elsewhen", Label = "Wikipedia Link", LinkType = LinkType.Wiki },
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


            };

            return (books, links);
        }
    }
}
