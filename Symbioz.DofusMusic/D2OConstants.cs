﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.DofusMusic
{
    public class D2OConstants
    {
        public static string GetRelativeSubarea(int soundId)
        {
            var a = SubareasSounds.FirstOrDefault(x => x.Value.Contains(soundId));

            if (a.Key != null)
            {
                return a.Key;
            }
            else
            {
                return "None";
            }
        }
        /// <summary>
        /// Dofus 2.38
        /// </summary>
        private static Dictionary<string, List<int>> SubareasSounds = new Dictionary<string, List<int>>()
        {
            {"Port de Madrestam", new List<int>(){17003,20100,29009,29010}},
            {"Montagne des Craqueleurs", new List<int>(){17018,20161,29009,29010}},
            {"Champ des Ingalsse", new List<int>(){17012,20170,29009,29010}},
            {"Forêt d Amakna", new List<int>(){17013,20100,29009,29010}},
            {"Coin des Bouftous", new List<int>(){17013,20170,29009,29010}},
            {"Cimetière", new List<int>(){17011,20117,29003,29010,17018,20105,29003,29010}},
            {"Cryptes", new List<int>(){17007,20121,29003,29010}},
            {"Campement des Bworks", new List<int>(){17007,20104,29008,29010}},
            {"Forêt maléfique", new List<int>(){17002,20106,29010,29011}},
            {"Village d Amakna", new List<int>(){17999,20100,29009,29010}},
            {"Territoire des Porcos", new List<int>(){17010,29010}},
            {"Péninsule des gelées", new List<int>(){17004,20155,29009,29010}},
            {"Bord de la forêt maléfique", new List<int>(){17013,20106,29010,29011}},
            {"Presqu île des Dragoeufs", new List<int>(){17020,20101,29008,29010}},
            {"Souterrains des Wabbits", new List<int>(){17039,20146,29008,29010}},
            {"Côte d Asse", new List<int>(){17004,20154,29009,29010}},
            {"Souterrains", new List<int>(){17006,20121,29003,29010}},
            {"Berceau", new List<int>(){17001,20100,29009,29010}},
            {"Marécage", new List<int>(){17015,20162,29004,29010}},
            {"Sufokia", new List<int>(){17003,20112,29010,29013}},
            {"Bois des Arak-haï", new List<int>(){17013,20123,29010,29011}},
            {"Prison", new List<int>(){17026,20121,29003,29010}},
            {"Repaire des roublards", new List<int>(){17007,20117,29003,29010}},
            {"Fortification de Bonta", new List<int>(){17012,20110,29001,29010}},
            {"Quartier des Boulangers", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Bouchers", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Forgerons", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Bûcherons", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Bricoleurs", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Tailleurs", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Quartier des Bijoutiers", new List<int>(){17999,20110,29001,29010,17999,20119,29006,29010}},
            {"Massif de Cania", new List<int>(){20113,29001,29010}},
            {"Pénates du Corbac", new List<int>(){17013,20152,29001,29010}},
            {"Lac de Cania", new List<int>(){17013,20151,29001,29010}},
            {"Landes de Sidimote", new List<int>(){17016,20108,29006,29010}},
            {"Cimetière des Héros", new List<int>(){17011,20117,29003,29010}},
            {"Cimetière des Torturés", new List<int>(){17011,20117,29003,29010}},
            {"Village des Dopeuls", new List<int>(){17012,20113,29001,29010}},
            {"Champs de Cania", new List<int>(){17001,20113,29001,29010}},
            {"Bois de Litneg", new List<int>(){17013,29001,29010}},
            {"Plaines Rocheuses", new List<int>(){17001,20151,29001,29010}},
            {"Gisgoul, le village dévasté", new List<int>(){17000,20108,29006,29010}},
            {"Égouts de Bonta", new List<int>(){17022,20110,29001,29010}},
            {"Égouts de Brâkmar", new List<int>(){17022,20119,29006,29010}},
            {"Village des Brigandins", new List<int>(){17019,20109,29008,29010}},
            {"Gelaxième dimension", new List<int>(){17004,20100,29009,29010}},
            {"Gelaxième dimension (royale)", new List<int>(){17004,20100,29009,29010}},
            {"Donjon des Bouftous", new List<int>(){17013,20125,29007,29010}},
            {"Foire du Trool", new List<int>(){17023,20111,29008,29010}},
            {"Contour d Astrub", new List<int>(){17013,20169,29009,29010}},
            {"Plage de la Tortue", new List<int>(){17004,20115,29004,29010}},
            {"Donjon du Bworker", new List<int>(){17007,20125,29007,29010}},
            {"Cité d Astrub", new List<int>(){17029,20100,29009,29010}},
            {"Exploitation minière d Astrub", new List<int>(){17006,20169,29009,29010}},
            {"Forêt d Astrub", new List<int>(){17013,20123,29010,29011}},
            {"Champs d Astrub", new List<int>(){17001,20169,29009,29010}},
            {"Souterrains d Astrub", new List<int>(){17007,20121,29003,29010}},
            {"Souterrains profonds d Astrub", new List<int>(){17007,20121,29003,29010}},
            {"Coin des Tofus", new List<int>(){17001,20169,29009,29010}},
            {"Champ du repos", new List<int>(){17002,20106,29010,29011}},
            {"Territoire des Bandits", new List<int>(){17004,20169,29009,29010}},
            {"Pandala Neutre", new List<int>(){17024,20116,29005,29010}},
            {"Bordure d Akwadala", new List<int>(){17024,20116,29005,29010}},
            {"Bordure de Feudala", new List<int>(){17029,20116,29005,29010}},
            {"Bordure d Aerdala", new List<int>(){17024,20116,29005,29010}},
            {"Bordure de Terrdala", new List<int>(){17024,20116,29005,29010}},
            {"Village d Aerdala", new List<int>(){17029,20116,29005,29010}},
            {"Village de Feudala", new List<int>(){17000,20116,29005,29010}},
            {"Village d Akwadala", new List<int>(){17029,20116,29005,29010}},
            {"Village de Terrdala", new List<int>(){17029,20116,29005,29010}},
            {"Village de Pandala", new List<int>(){17029,20116,29005,29010}},
            {"Caverne des Bulbes", new List<int>(){17002,20116,29005,29010}},
            {"Repaire des Pandikazes", new List<int>(){17019,20116,29005,29010}},
            {"Donjon des Kitsounes", new List<int>(){17024,20125,29007,29010}},
            {"Pont de Pandala", new List<int>(){17015,20103,29004,29010}},
            {"Donjon des Firefoux", new List<int>(){17000,20125,29007,29010}},
            {"Île de Grobe", new List<int>(){17002,20106,29010,29011}},
            {"Antre du Dragon Cochon", new List<int>(){17007,20125,29007,29010}},
            {"Île de la Cawotte", new List<int>(){17004,20147,29008,29010}},
            {"Îlot de Waldo", new List<int>(){17004,20148,29008,29010}},
            {"Îlot des Tombeaux", new List<int>(){17004,20146,29008,29010}},
            {"Îlot de la Couronne", new List<int>(){17007,20148,29008,29010}},
            {"Jungle Interdite", new List<int>(){17017,20115,29004,29010}},
            {"Forêt des Masques", new List<int>(){17017,20115,29004,29010}},
            {"Chemin du Crâne", new List<int>(){17032,20115,29004,29010}},
            {"Forêt Sombre", new List<int>(){17002,20106,29010,29011}},
            {"Orée de la forêt des Abraknydes", new List<int>(){17013,20100,29009,29010}},
            {"Plaine des Scarafeuilles", new List<int>(){17013,20169,29009,29010}},
            {"Forêt de Pandala", new List<int>(){17024,20116,29005,29010}},
            {"Prairies d Astrub", new List<int>(){17001,20169,29009,29010}},
            {"Domaine Ancestral", new List<int>(){17007,20125,29007,29010}},
            {"Plaine des Porkass", new List<int>(){17001,20113,29001,29010}},
            {"Coin des Boos", new List<int>(){17014,20170,29009,29010}},
            {"Château d Amakna", new List<int>(){20124,29009,29010}},
            {"Souterrains du Château d Amakna", new List<int>(){17007,20121,29003,29010}},
            {"Village des Eleveurs", new List<int>(){17018,20123,29010,29011}},
            {"Labyrinthe du Dragon Cochon", new List<int>(){17006,20125,29007,29010}},
            {"Donjon des Tofus", new List<int>(){17021,20125,29007,29010}},
            {"Île du Minotoror", new List<int>(){17004,20153,29004,29010}},
            {"Centre du labyrinthe du Minotoror", new List<int>(){17999,29010}},
            {"Bibliothèque du Maître Corbac", new List<int>(){17021,20125,29007,29010}},
            {"Donjon des Canidés", new List<int>(){17021,20125,29007,29010}},
            {"Caverne du Koulosse", new List<int>(){17007,20125,29007,29010}},
            {"Cimetière primitif", new List<int>(){17002,20117,29003,29010}},
            {"Lacs enchantés", new List<int>(){17018,20123,29010,29011}},
            {"Marécages nauséabonds", new List<int>(){17015,20164,29004,29010}},
            {"Marécages sans fond", new List<int>(){17015,20163,29004,29010}},
            {"Forêt de Kaliptus", new List<int>(){17018,20123,29010,29011}},
            {"Territoire des Dragodindes Sauvages", new List<int>(){17018,20123,29010,29011}},
            {"Sanctuaire des Familiers", new List<int>(){29010}},
            {"Pitons Rocheux des Craqueleurs", new List<int>(){17018,20125,29007,29010}},
            {"Canyon sauvage", new List<int>(){17018,20123,29010,29011}},
            {"Repaire de Skeunk", new List<int>(){17012,20123,29010,29011}},
            {"Vallée de la Morh Kitu", new List<int>(){17007,20121,29003,29010}},
            {"Campement des Gobelins", new List<int>(){17009,20104,29008,29010}},
            {"Village des Bworks", new List<int>(){17009,20104,29008,29010}},
            {"Élevage de Bouftous du Château d Amakna", new List<int>(){17001,20100,29009,29010}},
            {"Pâturages de Bonta", new List<int>(){17001,20113,29001,29010}},
            {"Bordure de Brâkmar", new List<int>(){17016,20108,29006,29010}},
            {"Donjon des Bworks", new List<int>(){17006,20125,29007,29010}},
            {"Donjon des Scarafeuilles", new List<int>(){17007,20125,29007,29010}},
            {"Donjon des Champs", new List<int>(){17013,20125,29007,29010}},
            {"Sanctuaire des Dragoeufs", new List<int>(){17007,20125,29007,29010}},
            {"Village des Dragoeufs", new List<int>(){17012,20101,29008,29010}},
            {"Souterrains des Dragoeufs", new List<int>(){17007,20101,29008,29010}},
            {"Labyrinthe du Minotoror", new List<int>(){29010}},
            {"Havre de Nowel", new List<int>(){17025,20301,29008,29010}},
            {"Donjon de Nowel", new List<int>(){17030,20125,29007,29010}},
            {"Donjon des Dragoeufs", new List<int>(){17007,20125,29007,29010}},
            {"Baie de Cania", new List<int>(){17004,29001,29010}},
            {"Calanques d Astrub", new List<int>(){17004,20154,29010,29013}},
            {"Donjon Ensablé", new List<int>(){17004,20125,29007,29010}},
            {"Donjon des Rats de Bonta", new List<int>(){17022,20125,29007,29010}},
            {"Donjon des Rats de Brâkmar", new List<int>(){17000,20125,29007,29010}},
            {"Donjon des Rats du Château d Amakna", new List<int>(){17022,20125,29007,29010}},
            {"Lac", new List<int>(){17028,20105,29009,29010}},
            {"Forêt", new List<int>(){17018,20105,29009,29010}},
            {"Champs", new List<int>(){17018,20105,29009,29010}},
            {"Pâturages", new List<int>(){17018,20105,29009,29010}},
            {"Temple Céleste", new List<int>(){17018,20105,29009,29010}},
            {"Crypte de Kardorim", new List<int>(){17999,20125,29007,29010}},
            {"Taverne", new List<int>(){17999,20105,29009,29010}},
            {"Route des âmes", new List<int>(){17018,20105,29009,29010}},
            {"Ile des naufragés", new List<int>(){17004,20118,29010,29013}},
            {"Mer", new List<int>(){17004,29010}},
            {"Plage de Corail", new List<int>(){17004,20118,29010,29013}},
            {"Plaines herbeuses", new List<int>(){17999,20118,29010,29013}},
            {"Jungle obscure", new List<int>(){17002,20106,29010,29011}},
            {"Tourbière sans fond", new List<int>(){17015,20103,29004,29010}},
            {"Canopée du Kimbo", new List<int>(){17013,20123,29010,29011}},
            {"Grotte Hesque", new List<int>(){17007,20125,29007,29010}},
            {"Arche d Otomaï", new List<int>(){17032,20125,29007,29010}},
            {"Clairière de Floribonde", new List<int>(){17013,20123,29010,29011}},
            {"Laboratoire du Tynril", new List<int>(){17039,20125,29007,29010}},
            {"Tronc de l arbre Hakam", new List<int>(){17013,20165,29009,29010}},
            {"Village des éleveurs", new List<int>(){17999,20118,29010,29013}},
            {"Village côtier", new List<int>(){17999,20118,29010,29013}},
            {"Cimetière de l île d Otomaï", new List<int>(){17013,20117,29003,29010}},
            {"Village des Zoths", new List<int>(){17019,20120,29010}},
            {"Village de la Canopée", new List<int>(){17019,20167,29008,29010}},
            {"Goulet du Rasboul", new List<int>(){17013,20125,29007,29010}},
            {"Tourbière nauséabonde", new List<int>(){17015,20103,29004,29010}},
            {"Feuillage de l arbre Hakam", new List<int>(){17013,20106,29010,29011}},
            {"Laboratoire caché", new List<int>(){17039,20125,29007,29010}},
            {"Cale de l arche d Otomaï", new List<int>(){20125,29007,29010}},
            {"Pont de Grobe", new List<int>(){17015,20103,29004,29010}},
            {"Rivière Kawaii", new List<int>(){17027,20170,29009,29010}},
            {"Montagne basse des Craqueleurs", new List<int>(){17018,20159,29009,29010}},
            {"Clairière de Brouce Boulgoure", new List<int>(){17013,20170,29009,29010}},
            {"Millifutaie", new List<int>(){17013,20170,29009,29010}},
            {"Campagne d Amakna", new List<int>(){17012,20170,29009,29010}},
            {"Sous-sol de la Bibliothèque", new List<int>(){17007,20100,29009,29010}},
            {"Rivage sufokien", new List<int>(){17004,20154,29009,29010}},
            {"Donjon des Larves", new List<int>(){17007,20125,29007,29010}},
            {"Passage vers Brâkmar", new List<int>(){17007,20108,29006,29010}},
            {"Clos des Blops", new List<int>(){17001,20125,29007,29010}},
            {"Donjon Fungus", new List<int>(){17007,20125,29007,29010}},
            {"Caverne des Fungus", new List<int>(){17007,20121,29003,29010}},
            {"Cimetière du village des Zoths", new List<int>(){17011,20117,29003,29010}},
            {"Îlot Estitch", new List<int>(){17011,20121,29003,29010}},
            {"Centre-ville", new List<int>(){17999,20119,29006,29010,17999,20110,29001,29010}},
            {"Donjon des Squelettes", new List<int>(){17006,20125,29007,29010}},
            {"Terres Désacrées", new List<int>(){17016,20108,29006,29010}},
            {"Landes de Cania", new List<int>(){17001,20151,29001,29010}},
            {"Dents de Pierre", new List<int>(){17010,20152,29001,29010}},
            {"Pics de Cania", new List<int>(){17018,20151,29001,29010}},
            {"Route de Brâkmar", new List<int>(){17010,20113,29001,29010}},
            {"Cirque de Cania", new List<int>(){17010,20151,29001,29010}},
            {"Routes Rocailleuses", new List<int>(){17001,29001,29010}},
            {"Route Sombre", new List<int>(){17016,20108,29006,29010}},
            {"Donjon des Forgerons", new List<int>(){17006,20125,29007,29010}},
            {"Faubourgs de Pandala", new List<int>(){17024,20116,29005,29010}},
            {"Quartier des Alchimistes", new List<int>(){17029,20110,29001,29010,17101,20119,29006,29010}},
            {"Quartier des Pêcheurs", new List<int>(){29010,17999,20119,29006,29010}},
            {"Quartier des Éleveurs", new List<int>(){17029,20110,29001,29010,17101,20119,29006,29010}},
            {"Tutoriel guidé", new List<int>(){17018,20105,29009,29010}},
            {"Château du Wa Wabbit", new List<int>(){17006,20125,29007,29010}},
            {"Terrier du Wa Wabbit", new List<int>(){17006,20125,29007,29010}},
            {"Maison premium", new List<int>(){17999,29002,29010}},
            {"Port de givre", new List<int>(){17003,20142,29010,29013}},
            {"La Bourgade", new List<int>(){17034,20139,29010,29012}},
            {"Champs de glace", new List<int>(){17033,20136,29010,29012}},
            {"Village enseveli", new List<int>(){17034,20139,29010,29012}},
            {"Forêt des pins perdus", new List<int>(){17031,20138,29010,29012}},
            {"Forêt pétrifiée", new List<int>(){17031,20138,29010,29012}},
            {"Crevasse Perge", new List<int>(){17033,20137,29010,29012}},
            {"Crocs de verre", new List<int>(){17031,20138,29010,29012}},
            {"Berceau d Alma", new List<int>(){17000,20141,29010,29012}},
            {"Larmes d Ouronigride", new List<int>(){17035,20141,29010,29012}},
            {"Mont Torrideau", new List<int>(){17033,20137,29010,29012}},
            {"Lac gelé", new List<int>(){17031,20136,29010,29012}},
            {"Entrée du château de Harebourg", new List<int>(){17038,20144,29010,29012}},
            {"Serre du Royalmouth", new List<int>(){17039,20125,29007,29010}},
            {"Excavation du Mansot Royal", new List<int>(){17030,20125,29007,29010}},
            {"Epave du Grolandais violent", new List<int>(){17032,20125,29007,29010}},
            {"Hypogée de l Obsidiantre", new List<int>(){17000,20125,29007,29010}},
            {"Tanière Givrefoux", new List<int>(){17030,20125,29007,29010}},
            {"Cavernes des Givrefoux", new List<int>(){17030,20125,29007,29010}},
            {"Antre du Korriandre", new List<int>(){17007,20125,29007,29010}},
            {"Cavernes du Kolosso", new List<int>(){17007,20125,29007,29010}},
            {"Mer Kantil", new List<int>(){29010}},
            {"Grottes gelées", new List<int>(){29010}},
            {"Port de Sakaï", new List<int>(){17025,20136,29010,29012}},
            {"Plaine de Sakaï", new List<int>(){17025,20136,29010,29012}},
            {"Forêt enneigée", new List<int>(){17013,20136,29010,29012}},
            {"Mine abandonnée de Sakaï", new List<int>(){17007,20125,29007,29010}},
            {"Village Kanniboul", new List<int>(){17017,20125,29007,29010}},
            {"Maison Fantôme", new List<int>(){17032,20125,29007,29010}},
            {"Goultarminator", new List<int>(){20125,29007,29010}},
            {"Prison des MJs", new List<int>(){29010}},
            {"Antichambre des Gloursons", new List<int>(){17036,20125,29007,29010}},
            {"Ruche des Gloursons", new List<int>(){17036,20125,29007,29010}},
            {"Nid du Kwakwa", new List<int>(){17007,20125,29007,29010}},
            {"Laboratoire de Brumen Tinctorias", new List<int>(){17039,20125,29007,29010}},
            {"Terre de Nowel", new List<int>(){17025,20301,29008,29010}},
            {"Taïga de Nowel", new List<int>(){17025,20301,29010,29011}},
            {"Caverne de Nowel", new List<int>(){17030,20125,29007,29010}},
            {"Maison du Papa Nowel", new List<int>(){17021,20125,29007,29010}},
            {"Village de Vulkania", new List<int>(){17004,20118,29010,29013}},
            {"Forêt d Etraktopel", new List<int>(){17002,20106,29010,29011}},
            {"Forêt d Espartiate", new List<int>(){17002,20106,29010,29011}},
            {"Forêt des Strates Igraphies", new List<int>(){17002,20106,29010,29011}},
            {"Forêt de Ponefarr", new List<int>(){17002,20106,29010,29011}},
            {"Cratère Pillar", new List<int>(){17007,21121,29010}},
            {"Cratère Mopyle", new List<int>(){17007,21121,29010}},
            {"Cratère Nehr", new List<int>(){17007,21121,29010}},
            {"Cratère Monseleya", new List<int>(){17007,21121,29010}},
            {"Cratère Minus", new List<int>(){17007,21121,29010}},
            {"Vulkania", new List<int>(){17004,20118,29010,29013}},
            {"Lantamaï", new List<int>(){17004,20118,29010,29013}},
            {"Kohrog", new List<int>(){17004,20118,29010,29013}},
            {"Enclos Instance", new List<int>(){17999,20100,29010}},
            {"Repaire de Daïgoro", new List<int>(){17024,20125,29007,29010}},
            {"Village du Pichon Frétillant", new List<int>(){17024,20116,29005,29010}},
            {"Mine", new List<int>(){17018,20105,29009,29010}},
            {"Territoire souterrain des Porcos", new List<int>(){17006,29010}},
            {"Tofulailler Royal", new List<int>(){17021,20125,29007,29010}},
            {"Clairière du Chêne Mou", new List<int>(){17007,20125,29007,29010}},
            {"Antre du Kralamoure Géant", new List<int>(){17015,20103,29004,29010}},
            {"Potager d Halouine", new List<int>(){17006,20125,29007,29010}},
            {"Jardins d Hiver", new List<int>(){17038,20145,29010,29012}},
            {"Remparts à vent", new List<int>(){17038,20143,29010,29012}},
            {"Tannerie Écarlate", new List<int>(){17038,20143,29010,29012}},
            {"Bastion des froides légions", new List<int>(){17038,20143,29010,29012}},
            {"Tour de la Clepsydre", new List<int>(){17042,20144}},
            {"Laboratoire de Nileza", new List<int>(){17039,20145,29010,29012}},
            {"Transporteur de Sylargh", new List<int>(){17040,20144,29010,29012}},
            {"Salons privés de Klime", new List<int>(){17999,20145,29010,29012}},
            {"Forgefroide de Missiz Frizz", new List<int>(){17006,20145,29010,29012}},
            {"Donjon du Comte Harebourg", new List<int>(){17042,20144}},
            {"Pied de la Tour de la Clepsydre", new List<int>(){17038,20144,29010,29012}},
            {"Antre du Blop Multicolore Royal", new List<int>(){17001,20125,29007,29010}},
            {"Temple des alliances", new List<int>(){17003,20112,29010,29013}},
            {"Laboratoires abandonnés", new List<int>(){17039,20146,29008,29010}},
            {"Île de Kartonpath", new List<int>(){17004,20149,29010,29013}},
            {"Théâtre de Dramak", new List<int>(){17032,20149,29007,29010}},
            {"Tunnel de Kartonpath", new List<int>(){17006,20149,29008,29010}},
            {"Salles des Embruns", new List<int>(){17037,20112,29010,29013}},
            {"Salles des Courants", new List<int>(){17037,20112,29010,29013}},
            {"Salles des Abîmes", new List<int>(){17037,20112,29010,29013}},
            {"Aquadôme de Merkator", new List<int>(){17037,20125,29007,29010}},
            {"Antre du Koulosse", new List<int>(){17007,20125,29007,29010}},
            {"Village des Kanigs", new List<int>(){17001,20152,29002,29010}},
            {"Grotte de Kanigroula", new List<int>(){17007,20125,29007,29010}},
            {"Base des Justiciers", new List<int>(){17999,20100}},
            {"Dimension Obscure", new List<int>(){17038,20171,29007,29010}},
            {"Pyramide d Ombre", new List<int>(){17038,20171,29007,29010}},
            {"Queue du Dragon", new List<int>(){17999,20125,29007}},
            {"Mine des Dopeuls", new List<int>(){17012,20113,29001,29010}},
            {"Galeries abandonnées", new List<int>(){17039,20146,29008,29010}},
            {"Volière de la Haute Truche", new List<int>(){}},
            {"Convention", new List<int>(){}},
            {"Creuset des Fortunés", new List<int>(){17044,20172,29010,29014}},
            {"Carrière Aurifère", new List<int>(){17006,20172,29010,29014}},
            {"Retraite des Éternels", new List<int>(){17006,20172,29010,29014}},
            {"Fabrique de Malléfisk", new List<int>(){17044,20172,29010,29014}},
            {"Galerie du Phossile", new List<int>(){17006,20172,29010,29014}},
            {"Palais du roi Nidas", new List<int>(){17044,20172,29010,29014}},
            {"Fort Thune", new List<int>(){17044,20172,29010,29014}},
            {"Ruelles des Eaux-Suaires", new List<int>(){17044,20173,29010,29014}},
            {"Catacombres", new List<int>(){17022,20173,29010,29014}},
            {"Hauts Ténébreux", new List<int>(){17044,20173,29010,29014}},
            {"Ring du Capitaine Ekarlatte", new List<int>(){17044,20173,29010,29014}},
            {"Cave du Toxoliath", new List<int>(){17039,20173,29010,29014}},
            {"Trône de la Cour Sombre", new List<int>(){17044,20173,29010,29014}},
            {"Quartier des Conquérants", new List<int>(){}},
            {"Roc des Salbatroces", new List<int>(){17033,20144,29010,29012}},
            {"Ventre de la Baleine", new List<int>(){17044,20172,29010,29014}},
            {"Chemins d hier", new List<int>(){17044,20174,29010,29016}},
            {"Jour présent", new List<int>(){17044,20174,29010,29016}},
            {"Lendemains incertains", new List<int>(){17044,20174,29010,29016}},
            {"Mégalithe de Fraktale", new List<int>(){17044,20174,29010,29016}},
            {"Horologium de XLII", new List<int>(){17044,20174,29010,29016}},
            {"Œil de Vortex", new List<int>(){17044,20174,29010,29016}},
            {"Cache de Kankreblath", new List<int>(){17999,20125}},
            {"Planque des Vilinsekts", new List<int>(){17029,20100,29009,29010}},
            {"Antre de la Reine Nyée", new List<int>(){17007,20125,29007,29010}},
            {"Palais de Bonta", new List<int>(){17999,20110,29001,29010}},
            {"Bateau du Chouque", new List<int>(){17017,20125,29010}},
            {"Arbre de Moon", new List<int>(){17017,20125,29010}},
            {"Île mystérieuse", new List<int>(){17006,20149,29008,29010}},
            {"Rocher des Sacrifiés", new List<int>(){17003,20112,29010,29013}},
            {"Hauts du Kramdam", new List<int>(){17004,20149,29010,29013}},
            {"Havres-Sacs", new List<int>(){}},
            {"Miausolée du Pounicheur", new List<int>(){20125,29010}},
            {"Plateau de Ush", new List<int>(){20175,29010}},
            {"Défi du Chalœil", new List<int>(){17021,20125,29010}},
            {"Pierres de l élévation", new List<int>(){20175,29010}},
            {"Lande Poilue", new List<int>(){20175,29010}},
            {"Temple de Kerubim", new List<int>(){20175,29010}},
            {"Confins", new List<int>(){17018,20105,29009,29010}},
            {"Maelström de Shariva", new List<int>(){}},
            {"Ville submergée", new List<int>(){20176,29025}},
            {"Ancienne Sufokia", new List<int>(){20176,29025}},
            {"Vestiges engloutis", new List<int>(){20176,29025}},
            {"Domaine des Trithons", new List<int>(){20177,29025}},
            {"Faille des Trithons", new List<int>(){20177,29025}},
            {"Tréfonds des Trithons", new List<int>(){20177,29025}},
            {"Plateau de R lyugluglu", new List<int>(){20178,29025}},
            {"Fosse de R lyugluglu", new List<int>(){20178,29025}},
            {"Abîme de R lyugluglu", new List<int>(){20178,29016}},
            {"Vaisseau du Capitaine Meno", new List<int>(){17037,20125,29010}},
            {"Palais de Dantinéa", new List<int>(){20125,29010}},
            {"Temple de Koutoulou", new List<int>(){20125,29010}},
            {"Dunes des ossements", new List<int>(){17045,20179,29010,29026}},
            {"Territoire Cacterre", new List<int>(){17045,20179,29010,29026}},
            {"Port de Sarakech", new List<int>(){17003,20179,29010,29026}},
            {"Cimetière des Mastodontes", new List<int>(){17045,20179,29010}},
            {"Caverne d El Piko", new List<int>(){17007,20179,29010,29018}},
            {"Rêve de Terrakourial", new List<int>(){}}

        };
    }
}
