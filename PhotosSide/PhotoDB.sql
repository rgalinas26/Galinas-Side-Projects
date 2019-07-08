DROP DATABASE IF EXISTS PhotoGallery;


CREATE DATABASE PhotoGallery;
GO

USE PhotoGallery;
GO

DROP TABLE IF EXISTS Photos;


CREATE TABLE photos
(
    id INTEGER PRIMARY KEY,
    name VARCHAR(250),
	image_name VARCHAR(50) NOT NULL,
	description NVARCHAR(1000) NOT NULL,
	isBird bit NOT NULL,
	isCVNP bit NOT NULL,
	isFlower bit NOT NULL,
);


INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
VALUES
    (1, 'Cardinal', 'Cardinal.jpg', 'A male Norther Cardinal that was attracted to my bird feeder. Unlike other species, Northern Cardinals
	biologically supress the West Nile Virus upon infection.', 1, 0, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
VALUES
    (2, 'DandelionPurple', 'DandelionPurple.jpg', 'A Dandelion growing amongst American Bluehearts. Dandelions are often
	thought of as pests, but their taproot extracts nutrients from deeper in the ground making the dandelion
	an ideal companion plant for shallower rooting plants.', 0, 0, 1);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (3, 'Hawk', 'Hawk.jpg', 'A (most likely) Red-Shouldered Hawk. Prior to the 1900s, the Red-Shouldered Hawk
	was one of the most common North American raptors. Deforestation and hunting reduced those numbers. This raptor is often confused
	with the Red-Tailed Hawk, which has a more pale underbelly and is typically larger than a Red-Shouldered Hawk.', 
	1, 0, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (4, 'Orchid', 'Orchid.jpg', 'A close-up picture of a Moth Orchid (Phalaenopsis) blossom. In my opinion, Orchids have an undeserved
	reputation for being hard to maintain. Water one a week with three ice cubes, and experiment with different light.
	The smallest Orchid in the world boasts flowers of just about 2mm wide. That Orchid belongs to the Platystele genus.', 
	0, 0, 1);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (5, 'ReflectedSky', 'ReflectedSky.jpg', 'The sky reflected on the lake at Furnace Run, a component of Summit Metro Parks.
	I have spent a fair amount of time exploring Furnace Run, and I recommend taking a walk, fishing, sledding, skating, 
	or cross-country skiing there (although I do none of that but walk)', 
	0, 1, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (6, 'SmallPurpleFlower', 'SmallPurpleFlower.jpg', 'A Wild Geranium featuring some sort of small polenating insect.
	The Wild Geranium is considered an astringent (a substance that causes tissue contract and stops bleeding). 
	The Meskwaki Native People made a Wild Geranium root tea to treat tootaches.', 
	0, 0, 1);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (7, 'Spider', 'Spider.jpg', 'A heavily edited photo of what I believe to be some sort of long-bodies Orbweaver spider.
	This photo was taken in the Brecksville Reservation just off Riverview Road. The spider was located up the river and 
	to the east on a dilapidated stump that hung over the water.', 
	0, 1, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (8, 'MagnoliaTree', 'SugarMagnolia.jpg', 'A photo taken beneath the canopy of a Saucer Magnolia Tree. The Saucer Magnolia
	is a hybrid Magnolia tree. It was originally bred by Étienne Soulange-Bodin in 1820. Étienne was a retired cavalry
	officer that served in The Grande Armée, which was commanded by Napoleon Bonaparte.', 
	0, 0, 1);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (9, 'BloodRoot', 'WhiteFlowerCVNP.jpg', 'A photo of what I have tentatively identified as Bloodroot. Ants spread 
	Bloodroot seeds in a process called myrmecochory. Bloodroot seeds have a fleshy organ called an elaiosome.
	Ants haul the seed to their nest where they eat the elaiosome then deposit the seed in nest debris. There,
	the seed is protected until it can germinate.', 
	0, 0, 1);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (10, 'BabyGrasshopper', 'BabyGrasshopper.jpg', 'Some sort of insect (juvenile?) found in the Brecksville Reservation
	some ways upriver. This photo was taken from roughly four inches away from the insect. The insect measured roughly one centimeter.
	When youre out in the park dont forget to look down from time to time!', 
	0, 1, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (11, 'LeafRiver', 'LeafRiver.jpg', 'A highly exposed, but unedited photo of a leaf caught inbetween some rocks below
	a rushing river. This photo was taken in a river within the Brecksville Reservation of the Metroparks. I owe this photo
	to Vasque hiking boots and their wonderful waterproofing technology.', 
	0, 1, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (12, 'MacroLeaf', 'MacroLeaf.jpg', 'A photo of the frozen floor of Deerlick Cave in the Brecksville Resrvation (Metroparks).
	This photo was taken from roughly four inches away. The Cleveland Metroparks describes Deerlick Cave as follows : 
	Millions of years ago an ocean covered what is now Ohio. 
	Salt from this ocean was trapped in the sands along the ocean’s shores. 
	The salt became embedded in the sandstone that formed from these ancient sands. 
	White-tailed deer need salt but don’t get it from the plants they eat, so they lick the salt from the sandstone, 
	giving Deer Lick Cave its name. Deer Lick Cave is not a true cave. 
	It’s actually a rock overhang formed through erosion of Berea sandstone by water.', 
	0, 1, 0);
INSERT INTO photos
    (id, name, image_name, description, isBird, isCVNP, isFlower)
	VALUES
    (13, 'Starling', 'Starling.jpg', 'A photo of several Common Starlings. Starlings have a wide range of vocalization
	and the male Starling can sometimes sing for a minute straight. Also, male starlings are seldom matched in their ability
	to fly, and so they are often preyed upon by hawks and falcons.', 
	1, 0, 0);




