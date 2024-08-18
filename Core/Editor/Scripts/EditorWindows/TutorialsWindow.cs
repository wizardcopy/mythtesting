﻿using UnityEngine;
using UnityEditor;
using System.Linq;

namespace Gyvr.Mythril2D
{
    public interface ITutorial
    {
        public string Title { get; }
        public string Description { get; }
        public string[] Paragraphs { get; }
    }

    public class TutorialGettingStarted : ITutorial
    {
        public string Title => "Getting Started";
        public string Description => "This tutorial covers the fundamentals of Mythril2D and how to get started.";
        public string[] Paragraphs => new string[]{
            "<b>What is Mythril2D?</b>\nMythril2D is a toolkit designed to help game developers create 2D action RPG games easily and efficiently. With Mythril2D, you can bring your unique ideas and vision to life without needing to write code.",
            "<b>Beginner mode:</b> If you're new to game development or working on smaller game productions, you can quickly create a game using the pre-made assets included in the demo game. These assets can be reused and supplemented with additional ones in the same art style, which can be found on the authors' websites (refer to the LICENSE documents for each third-party asset used in the demo game).",
            "<b>Advanced mode:</b> For more experienced users working on medium-sized game productions, you can kick-start your game production by using the demo game as a foundation and replacing the assets with your own. Keep in mind that RPG games require a large number of assets, including sprites, animations, music, and sound effects.",
            "<b>Expert mode:</b> If you're an expert user with a strong understanding of Mythril2D and working on larger game productions, you can start building your game from scratch using the core building blocks provided by the toolkit. This approach requires deep knowledge of Mythril2D and significant expertise in game development and design.",
            "<b>Ready to get started?</b>\nTo begin, I recommend exploring the available tutorials as well as the demo game. The demo game is an excellent resource for gaining a better understanding of how Mythril2D can be used to create unique RPG games. Take a closer look at the demo characters, abilities, maps, and other assets to see how they can be adapted and customized to suit your own vision and game design. With persistence and practice, you can master the tools and features of Mythril2D and create the game you've been dreaming of.",
            "<b><i>ScriptableObjects are essential to Mythril2D (see Database). If you're not familiar with them, check out some Unity tutorials before diving in to create your own games with Mythril2D.</i></b>"
        };
    }

    public class TutorialDatabase : ITutorial
    {
        public string Title => "Database";
        public string Description => "Learn about Mythril2D's database system, and how it can help you manage your game's assets.";
        public string[] Paragraphs => new string[]{
            "<b>DatabaseEntry</b>\nA DatabaseEntry is an extension of a ScriptableObject that works in tandem with a DatabaseRegistry, so that an asset can be referenced in a file saved on the disk at runtime, using a DatabaseEntryReference, and loaded from anywhere. It is the base class for most ScriptableObject used in Mythril2D, such as: Item, Quest, CharacterSheet, DialogueSequence etc...",
            "<b>DatabaseRegistry <i>(Create > Mythril2D > DatabaseRegistry)</i></b>\nThe DatabaseRegistry is a ScriptableObject that contains references to all the DatabaseEntry in your project. It is used to store and manage all the data you create for your game, such as characters, items, quests, and abilities. The DatabaseRegistry is automatically updated when you create or delete a DatabaseEntry, ensuring that your database is always up to date. This registry is referenced in the GameConfig (see Game Manager), and you shouldn't need to create more than one registry, unless you know exactly what you're doing! The demo game already comes with a registry, located at: <i>Assets/Mythril2D/Demo/Database/REGISTRY_Default</i>.",
            "<b>Database Editor Window</b>\nMythril2D's database window is a convenient editor window for browsing your DatabaseEntry. You can search for entries by type, such as HeroSheet, Item, or Quest.\nTo open the database window, click on the \"Window\" option in Unity's toolbar, navigate to \"Mythril2D\", and then select \"Database\" from the drop-down menu."
		};
    }

    public class TutorialScenes : ITutorial
    {
        public string Title => "Scenes";
        public string Description => "In this tutorial we're going to learn about Mythril2D scene system, and how you can create your very own maps.";
        public string[] Paragraphs => new string[]{
            "<b>Scene System</b>\nMythril2D uses Unity's additive scene loading, as well as asynchronous loading. There are two main scenes that can be loaded: Main Menu and Gameplay. These two scenes are standalone scenes that contain all the game logic, UI, and systems. However, loading only the Gameplay scene is a bit boring, and you may find yourself in an empty world! To make your Gameplay scene more fun, read more about maps!",
            "<b>Maps</b>\nA map can be viewed as a layer that Mythril2D loads on top of the Gameplay scene. It typically consists of level design elements, such as decorations, gameplay components, characters, and music. Maps are where you'll spend most of your time creating, in contrast to the Gameplay scene, which will mostly remain unchanged. A map can be loaded from the SaveSystem (see Game Systems) when a save file is loaded, or by a Teleporter (see Teleporters) when the player interacts with it (e.g., by entering a house).",
            "<b>Playtesting your maps</b>\nAs mentioned earlier, only the Main Menu and Gameplay scenes are actual standalone scenes. Your maps should always be used as a layer on top of the Gameplay scene. This means that by default, you cannot hit play while editing your map to test it. However, by adding a PlaytestManager (see the PlaytestManager prefab in the demo project) to your map, you can ask Mythril2D to load the Gameplay scene whenever you hit play! This makes iterating on a map much faster, without having to switch back and forth between the Gameplay scene and your map. The PlaytestManager also allows you to create scenarios with unique save files, so you can playtest your map with different parameters (e.g., different characters, items, quests, or game flags).",
        };
    }

    public class TutorialStats : ITutorial
    {
        public string Title => "Stats";
        public string Description => "In this tutorial we're going to learn about Mythril2D stats system.";
        public string[] Paragraphs => new string[] {
            "In Mythril2D, character statistics are composed of several attributes:\n" +
            "<b>- Health:</b> Determines the amount of damage a character can take before succumbing to defeat. Improving this stat increases overall survivability.\n" +
            "<b>- Physical Attack:</b> Determines the amount of damage dealt by physical attacks, such as sword strikes or arrow shots.\n" +
            "<b>- Magical Attack:</b> Governs the potency of magical spells and abilities, allowing for the manipulation of elements and the casting of powerful spells.\n" +
            "<b>- Physical Defense:</b> Determines the amount of damage absorbed from physical attacks, mitigating the harm dealt by blades and arrows.\n" +
            "<b>- Magical Defense:</b> Governs the character's resistance to magical attacks, reducing the damage taken from spells.\n" +
            "<b>- Agility:</b> Increases the chances of dodging a hit, and reduces the chance of missing a hit.\n" +
            "<b>- Luck:</b> Increases the chances of critical hits.\n" +
            "Increasing these attributes allow players to create unique characters to match their gameplay style.",
            "<b>Customized Attribute Naming</b>\nEach attribute can be renamed directly in the editor through the GameConfig (see Game Manager).",
            "<b>Customized Damage Calculation</b>\nDamage calculation can be customized for your game by editing the code of the DamageSolver class.",
			"<b>Level</b>\nThe maximum level is by default set to 20. You can change this by editing \"MaxLevel\" in the Stats class (see Stats.cs)."
		};

    }

    public class TutorialCharacterCreation : ITutorial
    {
        public string Title => "Character Creation";
        public string Description => "In this tutorial we're going to learn how to create characters for your game.";
        public string[] Paragraphs => new string[] {
            "<b>CharacterSheet <i>(Create > Mythril2D > Characters > ...)</i></b>\nA CharacterSheet is a DatabaseEntry that provides the basis for specific character sheets, such as HeroSheet, MonsterSheet, and NPCSheet. Creating a character sheet is the first step in building any game character.",
            "<b>SpriteLibrary</b>\nCharacters use a SpriteLibrary to determine their appearance. In the demo game, a SpriteLibrary contains animation frames and visuals for a character's hand. Different characters often use different SpriteLibraries. To populate a new SpriteLibrary, you may need to import a sprite sheet or use an existing one. Note that in the demo game, each character's SpriteLibrary uses Sprite Libraries/SLIB_Default as their Main Library to maintain consistent content structure.",
            "<b>Spawning your character</b>\nOnce you have a CharacterSheet (HeroSheet, MonsterSheet, or NPCSheet) and SpriteLibrary for your character, it's time to consider spawning it into your maps! It is recommended to create a prefab for each character. In the demo game, you can find base prefabs for each character type (0_Hero_Base, 0_Monster_Base, 0_NPC_Base) under Prefabs/Characters/. Creating a prefab variant from one of these base prefabs is a convenient way to create a prefab for your new character. Then, you can edit your prefab variant to use your SpriteLibrary and change your character settings as needed. You can learn more about the specificities of Heroes, Monsters, and NPCs in their respective tutorials."
        };

    }

    public class TutorialHeroes : ITutorial
    {
        public string Title => "Heroes";
        public string Description => "In this tutorial we're going to learn more about heroes";
        public string[] Paragraphs => new string[]{
            "Heroes are playable characters that are controlled using a PlayerController.",
            "<b>HeroSheet <i>(Create > Mythril2D > Characters > HeroSheet)</i></b>\nA HeroSheet allows you define how your hero acquires attribute points, its base stats, and abilities.",
            "<b>PlayerController <i>(MonoBehaviour)</i></b>\nThe PlayerController component interacts with the InputSystem (see Game Systems) to read and interpret the inputs, and translate these into movements and ability firing for a hero."
        };
    }

    public class TutorialEntities : ITutorial
    {
        public string Title => "Entities";
        public string Description => "In this tutorial we're going to learn more about entities";
        public string[] Paragraphs => new string[]{
            "<b>Entity <i>(MonoBehaviour)</i></b>\nThe Entity class is the base class for pretty much anything that moves, interacts, or can be interacted with. Think of it as Mythril2D's main component that your GameObjects should have if you want them to interact or be interacted with. An interactable sign, a chest, or even a lever for your players to toggle, are all entities. Monsters, NPCs, and even Heroes (such as your player), inherit from Entity.",
            "<b>Defining an interaction for an entity</b>\nEntities become interactable when they have an interaction defined through the inspector. An \"Interaction\" can actually be many things, such as a single action, a conditional action, a sequence of actions, and more! Learn more about the interaction system in the \"Interactions\" tutorial!",
            "<b>Adding an interactable entity to your scene</b>\nIn order for a GameObject to be interactable, it must have an Entity component. You can add an Entity component to any GameObject by clicking on the \"Add Component\" button in the inspector, searching for \"Entity\", and clicking on it. Once the Entity component is added, you can define an interaction for the entity by changing the \"Interaction\" setting through the inspector. For a GameObject to be interactable, you'll need to set its layer to \"Interaction\", and add a rigibody and collider to it.",
        };
    }

    public class TutorialInteractions : ITutorial
    {
        public string Title => "Interactions";
        public string Description => "In this tutorial we're going to learn more about Mythril2D's interaction system";
        public string[] Paragraphs => new string[]{
            "An interaction in Mythril2D is a simple way to define a behavior that <i>could</i> (if certain conditions are met) be executed when the player uses the interaction key while looking at an entity.",
            "<b>IInteraction <i>(Interface)</i></b>\nIInteraction is the base interface for all interactions in Mythril2D. It contains a single method, TryExecute, that is called when the interaction is triggered. TryExecute is expected to return true if the interaction has been executed, and false otherwise. Depending on your use case, you could chain interactions based on the return of the TryExecute method, allowing you to create complex interactions, like, for instance, trying to complete a quest, and if this interaction didn't return true, showing a dialogue message.",
            "<b>Built-in interactions</b>\nMythril2D comes with a few built-in interactions that you can use right away, such as the DialogueInteraction, QuestInteraction, and ShopInteraction. These interactions are used in the demo game to create dialogues, quest interactions (giving a hint, offering, or completing a quest), and shops. Some more advanced interactions are also available, such as the SequenceInteraction, which allows you to chain multiple interactions together, and the ConditionalInteraction, which allows you to execute an interaction based on a condition.",
            "<b>Creating a custom interaction</b>\nYou can also create your own interactions by implementing the IInteraction interface."
        };
    }

    public class TutorialNPCs : ITutorial
    {
        public string Title => "NPCs";
        public string Description => "In this tutorial we're going to learn more about NPCs";
        public string[] Paragraphs => new string[]{
            "NPCs are characters that players can interact with. Whether you want to set up a shop, an inn, a dialogue, or give a quest to the player, NPCs are the way to go. NPCs inherit their interaction capabilities from the Entity class (see Entities). You can create unique characters for your game and add depth to your story by creating interesting interactions with the player.",
            "<b>NPCSheet <i>(Create > Mythril2D > Characters > NPCSheet)</i></b>\nAn NPCSheet is a simple way to refer to a specific character. In video games, the same NPC (one NPCSheet) may appear in different locations. The sheet is used to identify the character, so the location of the character's specific GameObject doesn't matter if a quest requires interaction with the character.",
            "<b>Interactions</b>\nOnce your NPC created (see Character Creation), select it to display its components in the inspector. Find the NPC component. Under this component you will find the \"Interaction\" setting, which allow you to setup which interaction(s) should be executed (See Interations for more details). By default, the 0_NPC_Base prefab will contain a sequential interaction with one entry: QuestInteraction. You can add additional interactions, such as a shop interaction, an inn interaction, and more. The QuestInteraction should generally be placed first in the interaction sequence, so that if a quest can be obtained or completed, it will always be done first."
        };
    }

    public class TutorialMonsters : ITutorial
    {
        public string Title => "Monsters";
        public string Description => "In this tutorial we're going to learn more about monsters";
        public string[] Paragraphs => new string[]{
            "Monsters are characters that are generally controlled using an AIController.",
            "<b>MonsterSheet <i>(Create > Mythril2D > Characters > MonsterSheet)</i></b>\nA MonsterSheet lets you define how a monster's stats evolve with level, their available abilities, and rewards when defeated (money, experience, items...).",
            "<b>AIController <i>(MonoBehaviour)</i></b>\nThe AIController component determines which movement to perform or ability to fire based on the character's surroundings. You can extend the AIController class to create unique behaviors for your monsters. The current AIController doesn't support multiple abilities or advanced decision making. Depending on your production's needs, you can also use a state machine instead of an AIController.",
            "<b>MonsterSpawner <i>(MonoBehaviour)</i></b>\nThe MonsterSpawner allows you to spawn monsters at a specific location based on predetermined criteria.",
            "<b>MonsterAreaSpawner <i>(MonoBehaviour)</i></b>\nThe MonsterAreaSpawner is a variant of the MonsterSpawner that allows you to spawn monsters anywhere within a collider's area. This is useful when you want to create dynamic and unpredictable monster spawns in your game."
        };
    }

    public class TutorialDialogues : ITutorial
    {
        public string Title => "Dialogues";
        public string Description => "In this tutorial we're going to learn about Mythril2D dialogue system, and how to create complex dialogue sequences.";
        public string[] Paragraphs => new string[]{
            "<b>DialogueSequence <i>(Create > Mythril2D > Dialogues > DialogueSequence)</i></b>\nThis DatabaseEntry is the entry point for any dialogue.",
            "<b>Creating a dialogue</b>\nThe first step when creating a dialogue is to create a DialogueSequence.",
            "<b>Dialogue lines</b>\nA DialogueSequence contain an array of lines (DialogueNode) that can be displayed in a UI dialogue message box. When writing your lines, you have to make sure not to overflow the output message box.",
            "<b>Dialogue options</b>\nAfter all the lines in your DialogueSequence have been displayed, it's time to offer choices to the player. If no options are provided (i.e., option count = 0), the dialogue will terminate after the last line is displayed. If only one option is set, the provided DialogueSequence will automatically play following the current sequence. This is very convenient when working with branching conversations, as multiple sequences can converge to the same sequence. If more than one option is available to the player, you can name these options by filling in the first text field. Finally, the dropdown at the end of the option line allows you to add specific strings to the message feed, which will be explained later.",
            "<b>Message Feed</b>\nDialogue options can populate the message feed, changing the course of action in your game. Some scripts may play a dialogue sequence and read the message feed at the end of its execution. Each option can add one string to the message feed. For instance, a dialogue sequence used to initiate a quest is expected to contain \"Accept\" or \"Decline\", meaning that your sequence should probably include these options somewhere. The Demo game's quest dialogues offer great examples of using the message feed. You can also populate the message feed with custom strings and retrieve and parse these strings in a script. This can be useful for advanced users who want to expand Mythril2D by creating custom scripts. In most cases, \"Accept\" and \"Decline\" messages will be used for dialogue sequences used for shops, inns, or quests.",
            "<b>Execute on completion</b>\nAt the start or end of a dialogue sequence, it's also possible to execute a command (see Commands tutorial) to run complex logic, such as healing a player in the middle of a dialogue, setting a game flag, or giving the player an item.",
        };
    }

    public class TutorialItems : ITutorial
    {
        public string Title => "Items";
        public string Description => "In this tutorial we're going to learn about Mythril2D items.";
        public string[] Paragraphs => new string[]{
            "<b>Items <i>(Create > Mythril2D > Items > Item)</i></b>\nIn Mythril2D, an item is an object that can be acquired (e.g., as a quest reward, loot) and disposed of (e.g., selling, using). Items have a price which they can be bought or sold for in shops (see Shops & Inns), and by default, have no effect when used. Creating special effects for items requires extending the Item class in a script. In the demo game, this base class is extended to create health and mana potions, as well as equipment. In fact, equipment inherits from Item.",
            "<b>Equipment <i>(Create > Mythril2D > Items > Equipment)</i></b>\nEquipment in Mythril2D refers to items that a hero can equip in special inventory slots. While equipped, the hero will benefit from the bonus stats specified in the equipment settings. Currently, equipment has no restrictions on weight or class, and any hero can equip any equipment."
        };
    }

    public class TutorialAbilities : ITutorial
    {
        public string Title => "Abilities";
        public string Description => "In this tutorial we're going to learn about Mythril2D abilities.";
        public string[] Paragraphs => new string[]{
            "<b>Ability sheets <i>(Create > Mythril2D > Abilities > ...)</i></b>\nSimilarly to character sheets, ability sheets allow you to define settings for your abilities, such as the name, icon, and description. The AbilitySheet class is the base class for any type of ability, including damaging abilities (DamageAbilitySheet), healing abilities (HealAbilitySheet), and more.",
            "<b>Ability prefabs</b>\nFor each ability sheet you create, you must include a reference to a prefab containing the actual visuals and gameplay code of your ability. This prefab must include an ability script that is compatible with the ability sheet type you are creating (e.g., DamageAbilitySheet, HealAbilitySheet). For instance, if you create a prefab with a MeleeAttackAbility component (MonoBehaviour) for your ability, you must create a sheet of type DamageAbilitySheet and add a reference to your prefab in this sheet.",
            "<b>Adding abilities to your characters</b>\nHeroes and monsters can be assigned abilities through their respective character sheets. When a character using a HeroSheet or a MonsterSheet is spawned, it will automatically instantiate the ability prefabs for each ability that character has unlocked."
        };
    }

    public class TutorialCommands : ITutorial
    {
        public string Title => "Commands";
        public string Description => "In this tutorial we're going to learn about Mythril2D command system, including how to use and create new commands.";
        public string[] Paragraphs => new string[]{
            "<b>ICommand <i>(Interface)</i></b>\nICommand is an interface that you can implement in C# to create your very own commands and call them from almost anywhere (quest completion, monster's death, on interaction...). Anything can be turned into a command: Healing your players, adding items to their inventories, playing a dialogue or a sound... Mythril2D comes with a plethora of basic commands that can be used in many games, but creating your own is very simple! Check out the add-ons section on the Discord server; I'm sure you'll find some cool commands there.",
            "<b>CommandHandler <i>(Create > Mythril2D > Utils > CommandHandler)</i></b>\nA CommandHandler allows you to create a preset for a specific command and its settings. Let's say you want to execute a command with some predetermined settings from multiple locations. Instead of setting up your command and its settings at each location where you need to execute it, you can create an instance of CommandHandler, set it up, and pass it as a reference to the ExecuteCommandHandler command where you want to execute it. It also works well with Unity's built-in event system, allowing you to specify a CommandHandler to execute by referencing the \"Execute()\" method of a particular CommandHandler instance! (This is how I handle UI sounds in the demo game, using Unity's EventTrigger component and two CommandHandler instances: one for the UI select sound, and one for the UI submit sound)",
            "<b>CommandTrigger <i>(MonoBehaviour)</i></b>\nYou can add the CommandTrigger component to any GameObject in your scene to execute a command when a specific event occurs (on start, on interaction, on trigger enter, etc.). You can also define multiple conditions that need to be met for the command to be executed. The CommandTrigger can come in very handy for:\n- Playing background music on start (used on each map of the demo game).\n- Playing a dialogue when a map is loaded (used by the demo game for the Abandoned House).\n- Making an element of your game interactive by adding dialogues (such as the ladder in the Abandoned House of the demo game).\n- And much more!"
        };
    }

    public class TutorialQuests : ITutorial
    {
        public string Title => "Quests";
        public string Description => "In this tutorial we're going to learn about Mythril2D quests.";
        public string[] Paragraphs => new string[]{
            "<b>Quest <i>(Create > Mythril2D > Quests > Quest)</i></b>\nA Quest in Mythril2D is a DatabaseEntry that contains a list of tasks that the player has to execute to receive a reward and/or execute a specific command (see Commands). Quests are offered by NPCs and must be given back to the same or other NPCs. You can also a level requirement to a quest, making it only available to players of a certain level.",
            "<b>QuestTask<i>(Create > Mythril2D > Quests > Tasks > ...)</i></b>\nA QuestTask is also a DatabaseEntry. It is the base class for any task that can be added to a quest, and can be expanded programmatically to create new objectives. By default, Mythril2D includes two tasks: ItemTask and KillMonsterTask.",
            "<b>ItemTask <i>(Create > Mythril2D > Quests > Tasks > ItemTask)</i></b>\nAn ItemTask is a task where the player needs to collect a specific item. For example, if a quest asks the player to collect 4 crystal balls, you must make sure that these crystal balls cannot be disposed of; otherwise, the player could make your quest unfinishable by, for instance, selling your quest item (note: you can make an item non-sellable by setting its price to 0).",
            "<b>KillMonsterTask <i>(Create > Mythril2D > Quests > Tasks > KillMonsterTask)</i></b>\nThis task requires the player to kill a certain monster a specific amount of times."
        };
    }

    public class TutorialGameFlags : ITutorial
    {
        public string Title => "Game Flags";
        public string Description => "In this tutorial we're going to learn about Mythril2D game flags.";
        public string[] Paragraphs => new string[]{
            "A game flag is a unique string identifier that can be set or unset (boolean), stored and saved in a save file, and used for game condition checking. For instance, you may want a certain action in your game to alter the dialogues, monsters, or visuals. You can do this by setting a game flag when this action occurs and checking if this game flag is set using a GameConditionChecker (see Game Conditions).",
        };
    }

    public class TutorialChests : ITutorial
    {
        public string Title => "Chests";
        public string Description => "In this tutorial we're going to learn about Mythril2D chests.";
        public string[] Paragraphs => new string[]{
            "<b>Chest <i>(Entity)</i></b>\nA chest is a gameplay element that may contain an item and can be in an opened or closed state. If set with the single-use setting, the chest needs to provide a unique game flag ID (see Game Flags), which will be used to identify the chest and make sure that it won't be opened twice.",
            "<b>ChestInteraction <i>(IInteraction)</i></b>\nThe ChestInteraction class contains the logic to trigger the opening of a chest.",
            "<b>Creating a chest</b>\nTo add a chest to your map, you can drag and drop the Chest prefab from the demo game into your scene and update its settings under the Chest script section.",
        };
    }

    public class TutorialTeleporters : ITutorial
    {
        public string Title => "Teleporters";
        public string Description => "In this tutorial we're going to learn about Mythril2D teleporters.";
        public string[] Paragraphs => new string[]{
            "<b>Teleporter <i>(MonoBehaviour)</i></b>\nA Teleporter is a gameplay element that can teleport the player from one location to another within the same map or to another map. It is necessary for any map transition (going from outside to inside) or specific gameplay mechanics. It can be set up to teleport the player on contact if the player is moving in a certain direction. It can also be set to play a sound when the teleportation occurs.",
            "<b>Creating a teleporter</b>\nTo add a teleporter to your map, you can drag and drop the Teleporter prefab from the demo game into your scene and update its settings under the Teleporter script section.",
        };
    }

    public class TutorialShopsAndInns : ITutorial
    {
        public string Title => "Shops & Inns";
        public string Description => "In this tutorial we're going to learn about Mythril2D shops and inns.";
        public string[] Paragraphs => new string[]{
            "<b>Shop <i>(Create > Mythril2D > Shops > Shop)</i></b>\nA Shop is a DatabaseEntry that contains a list of items that are available for sale. It can also specify a selling and buying multiplier to discount or increase the price of items bought or sold. Once created, the shop instance can be passed to an NPC using the NPCShop interaction (see NPCs).",
            "<b>Inn <i>(Create > Mythril2D > Inns > Inn)</i></b>\nAn Inn is a DatabaseEntry that defines how much health and mana should be restored and at what price. Once created, the inn instance can be passed to an NPC using the NPCInn interaction (see NPCs)",
        };
    }

    public class TutorialAudio : ITutorial
    {
        public string Title => "Audio";
        public string Description => "In this tutorial we're going to learn about Mythril2D audio.";
        public string[] Paragraphs => new string[]{
            "The Mythril2D audio system uses a non-deterministic request-based audio playback system. This means that for a script to play music or a sound, it needs to issue a playback request, and its fulfillment may depend on the current setup. For instance, if a script requests to play background music but no background music channel exists, the sound simply won't be played, and the game will ignore it.",
            "<b>AudioChannel <i>(MonoBehaviour)</i></b>\nIn Mythril2D, music and sounds are played through audio channels. An AudioChannel defines how sounds can be played, with the exclusive mode allowing for one sound at a time, and the multiple mode allowing for the playback of multiple sounds in parallel. Each AudioChannel has its own AudioSource, allowing you to set different settings, such as volume and pitch, for each channel. For example, you can set the AudioChannel for background music with a lower volume than the other channels. These AudioChannels are referenced in the AudioSystem (see Game Systems).",
            "<b>AudioClipResolver <i>(Create > Mythril2D > Audio > AudioClipResolver)</i></b>\nIn video games, it is common to refer to the same audio clip at multiple locations. However, updating an audio clip can require changes to all the places where the previous clip was used. To overcome this issue and to facilitate audio clip selection when dealing with multiple clips, Mythril2D has introduced an AudioClipResolver. This DatabaseEntry serves as a reference to one or multiple audio clips, and dynamically selects an audio clip using the chosen algorithm. It also specifies the audio channel in which the clip should be played.",
            "<b>AudioRegion <i>(MonoBehaviour)</i></b>\nIn some cases, you may want to play a specific sound when the player enters a region of a map. To achieve this, you can add an AudioRegion component that will temporarily suspend the background music when the player enters its trigger zone and resume playback once the player leaves it.",
        };
    }

    public class TutorialGameManager : ITutorial
    {
        public string Title => "Game Manager";
        public string Description => "In this tutorial we're going to learn about Mythril2D game manager.";
        public string[] Paragraphs => new string[]{
            "<b>Game Manager <i>(MonoBehaviour)</i></b>\nThe GameManager is a component that needs to be added to your Main Menu and Gameplay scenes. It is essential for any game made with Mythril2D. The role of the GameManager is to keep track of all game systems (see Game Systems) and make them publicly available using a Singleton pattern. You can think of the GameManager as the mediator for your game logic. Additionally, the GameManager holds a reference to a GameConfig instance. A GameConfig object is where you store all the details about your game, including gameplay and game terms.",
            "<b>GameConfig <i>(Create > Mythril2D > Game > GameConfig)</i></b>\nThe GameConfig DatabaseEntry is an object that lets you fully configure your game, such as whether or not you can critically hit or miss a hit, and configure all the game terms, such as currency, experience, level, etc. This allows you to define how things such as the \"Health\" stat should be called in your game. Maybe you want to call it \"HP\" or \"Life Points\". It's up to you to decide!"
        };
    }

    public class TutorialGameSystems : ITutorial
    {
        public string Title => "Game Systems";
        public string Description => "In this tutorial we're going to learn about Mythril2D game systems.";
        public string[] Paragraphs => new string[]{
            "<b>What are game systems?</b>\nMythril2D uses a system approach to handle persistent gameplay logic, such as the inventory system, the audio system, the journal system, etc. Systems are generally set up under the GameManager in the Main Menu and Gameplay scene, meaning that they should be instanced once and stay alive even when the currently loaded map changes.",
            "<b>InputSystem <i>(MonoBehaviour)</i></b>\nOrganizes all the inputs set up in Unity's Input System and exposes them to other scripts. It also handles input locking (during a map transition, for instance) and action map switches.",
            "<b>InventorySystem <i>(MonoBehaviour)</i></b>\nStores and handles the player's inventory, including operations such as adding an item, equipping an item, or managing money.",
            "<b>JournalSystem <i>(MonoBehaviour)</i></b>\nStores and handles the player's quests, including operations such as starting a quest and completing a quest.",
            "<b>NotificationSystem <i>(MonoBehaviour)</i></b>\nContains several events that can be subscribed to by other systems or scripts and invoked to react to gameplay events, such as dispatching an audio playback request.",
            "<b>SaveSystem <i>(MonoBehaviour)</i></b>\nHandles the creation, deletion, and loading of save files.",
            "<b>GameStateSystem <i>(MonoBehaviour)</i></b>\nKeeps track of game states, such as Gameplay and UI, to allow systems and scripts to adapt themselves based on the current game state.",
            "<b>GameFlagSystem <i>(MonoBehaviour)</i></b>\nStores and handles operations on game flags. Can be used by scripts to set or check a specific game flag (such as a chest storing a game flag once it has been opened, so it cannot be opened twice).",
            "<b>MapLoadingSystem <i>(MonoBehaviour)</i></b>\nHandles the loading and unloading of maps. When set up with delegated transition responsibility, it will delegate its operations to allow for an external system or script (such as the UISceneTransition script in the demo game) to initiate and stop the loading/unloading.",
            "<b>DialogueSystem <i>(MonoBehaviour)</i></b>\nStores a reference to the main dialogue channel, which will handle all the dialogue logic. Can be extended to support multiple channels (ex: gameplay blocking dialogues within a dialogue message box, and chat bubbles on top of game characters when the player is near them.",
            "<b>PlayerSystem <i>(MonoBehaviour)</i></b>\nHandles the instantiation of the player prefab. By default, the PlayerSystem will spawn the prefab set in its \"Dummy Player Prefab\" field. Do note that the save system will have the last say on which prefab the game should use as the player. The dummy prefab will generally be used when no save file is loaded.",
            "<b>PhysicsSystem <i>(MonoBehaviour)</i></b>\nAlters Unity's Physics System to behave differently with projectiles (only purpose of this system so far but can be extended to meet your production's needs).",
            "<b>AudioSystem <i>(MonoBehaviour)</i></b>\nHandles multiple AudioChannel for AudioClipResolver to be played (see Audio). You can set up your channel list as you see fit, with up to 5 different channels (background music, background sound, gameplay sound FX, interface sound FX, and miscellaneous."
        };
    }

    public class TutorialNavigationCursors : ITutorial
    {
        public string Title => "Navigation Cursors";
        public string Description => "In this tutorial we're going to learn about Mythril2D navigation cursors.";
        public string[] Paragraphs => new string[]{
            "<b>What is a navigation cursor?</b>\nA navigation cursor is a UI element that follows the currently selected UI element to provide information to the player about which element is currently being selected. For instance, you may want a frame to show around an item slot in your inventory whenever this slot is selected.",
            "<b>UINavigationCursor <i>(MonoBehaviour)</i></b>\nThis component, when added to a GameObject in your screen space UI, allows you to display an image to show on top of selected UI elements.",
            "<b>UINavigationCursorTarget <i>(MonoBehaviour)</i></b>\nAdd this component to any UI element you want the navigation cursor to react to. If a UI element has this component, the UINavigationCursor will automatically move to it once selected.",
            "<b>NavigationCursorStyle <i>(Create > Mythril2D > UI > NavigationCursorStyle)</i></b>\nThis DatabaseEntry defines the style the navigation cursor should adopt when highlighting an element. You can create as many styles as you want for each different UI element in your game."
        };
    }

    public class TutorialConditionalActivators : ITutorial
    {
        public string Title => "Conditional Activators";
        public string Description => "In this tutorial we're going to learn about Mythril2D conditional activators.";
        public string[] Paragraphs => new string[]{
            "Conditional activators are components you can add in your maps to enable or disable specific GameObjects if some conditions are satisfied.",
            "<b>ConditionalChildrenActivator <i>(MonoBehaviour)</i></b>\nEnable or disable all its children if a condition is met.",
            "<b>ConditionalReferencesActivator <i>(MonoBehaviour)</i></b>\nEnable or disalbe all its references if a condition is met."
        };
    }

    public class TutorialTilemapLayers : ITutorial
    {
        public string Title => "Tilemap Layers";
        public string Description => "In this tutorial we're going to learn about Mythril2D tilemap layers.";
        public string[] Paragraphs => new string[]{
            "In the Mythril2D demo game, the environment is rendered using Unity tilemaps. The maps in this demo are set up to use a combination of 4 layers. Each tilemap layer has its own tilemap collider and is rendered with its own sorting layer (the demo game uses the sorting layers: A, B, C, and Default). The purpose of using multiple tilemaps is to visually represent depth in the environment. For instance, you may want a mushroom tile (with a transparent background) to be displayed on top of a grass tile, so placing the grass tile on Layer A and the mushroom tile on Layer B would be a good idea. It's up to you to decide what goes into each layer, as well as how many layers you want to use. The player is rendered in the Default sorting layer, so the depth resolution between any tile in the Default layer and the player will be based on the Y coordinate of these elements. Therefore, for any tile that the player can walk behind (such as a tree, a big rock, a fence, or a house), it would make sense to place this tile on the Default layer and let Unity resolve the sorting order by comparing the Y coordinate of the tile and the player."
        };
    }

    public class TutorialSaveFiles : ITutorial
    {
        public string Title => "Save Files";
        public string Description => "In this tutorial we're going to learn about Mythril2D save files.";
        public string[] Paragraphs => new string[]{
            "<b>SaveFile <i>(Create > Mythril2D > Save > SaveFile)</i></b>\nA SaveFile in Mythril2D is a DatabaseEntry that contains settings defining the map where the player should start the game, its initial position, inventory, available quests, default equipped abilities, and more.",
            "<b>Available Quests</b>\nThis section of a save file is very important to update when building your game, as it defines which quests the players will be able to acquire, and therefore complete, from the beginning of the adventure. It could contain, for instance, the first quest of the main story line and a set of side quests. Quests can also be set up to unlock other quests.",
            "<b>Using a SaveFile</b>\nNewly created save files won't be used by default. These DatabaseEntry can be used in the main menu as an argument passed to the <i>UIMainMenu.StartNewGameFromDefaultSaveFile</i> method. In the demo game, the main menu contains 3 buttons to start a new game: Wizard, Knight, and Archer. Each of these buttons, when clicked, will call the <i>UIMainMenu.StartNewGameFromDefaultSaveFile</i> method using the given save file as an argument. Your newly created save files can be referenced from the inspector of these buttons, under the Button component's \"OnClick\" event."
        };
    }

    public class TutorialPlayerProfiles : ITutorial
    {
        public string Title => "Player Profiles";
        public string Description => "Let's look into player profiles in Mythril2D.";
        public string[] Paragraphs => new string[]{
            "<b>PlayerProfile <i>(Create > Mythril2D > Save > PlayerProfile)</i></b>\nA PlayerProfile is a DatabaseEntry that contains information about a specific hero that can be referenced in a save file, but cannot be modified during gameplay. You can expand this class to store additional information about your hero that should not be directly saved to the disk, but instead referenced by a save file."
        };
    }

    public class TutorialCrafting : ITutorial
    {
        public string Title => "Crafting";
        public string Description => "In this tutorial we're going to learn about Mythril2D crafting system.";
        public string[] Paragraphs => new string[]{
            "<b>Recipe <i>(Create > Mythril2D > Crafting > Recipe)</i></b>\nA Recipe in Mythril2D is a DatabaseEntry that contains a list of ingredients and their quantities (input) as well as an item (output). Creating a recipe is necessary for each item you want your players to be able to craft. You can also set a crafting fee, which will require your players to have a set amount of your game currency to craft this recipe.",
            "<b>CraftingStation <i>(Create > Mythril2D > Crafting > CraftingStation)</i></b>\nSimilarly to shops, CraftingStations are DatabaseEntry that allow you to create a set of recipes to be used somewhere in your game, whether it's from your players' inventories, or through a specific NPC (see NPCs), as well as defining additional fees your players will need to pay to craft items.",
            "<b>\"On The Go\" CraftingStation</b>\nThis special CraftingStation can be set through the GameConfig (see GameManager), and will determine which recipes should be made available to your players directly through the pause menu (which we usually refer to as \"On The Go\" crafting). You can also set this field to \"None\" in the GameConfig, this will prevent the crafting menu from showing up in the pause menu. Even if the \"On The Go\" crafting station isn't set, you can still create CraftingStations and NPCs to allow your players to craft at specific locations (such as an alchemist, a blacksmith, etc...)."
        };
    }

    public class TutorialsWindow : EditorWindow
    {
        public ITutorial[] m_tutorials = new ITutorial[] {
            new TutorialGettingStarted(),
            new TutorialDatabase(),
            new TutorialScenes(),
            new TutorialTilemapLayers(),
            new TutorialEntities(),
            new TutorialInteractions(),
            new TutorialChests(),
            new TutorialTeleporters(),
            new TutorialStats(),
            new TutorialHeroes(),
            new TutorialNPCs(),
            new TutorialMonsters(),
            new TutorialCharacterCreation(),
            new TutorialAbilities(),
            new TutorialItems(),
            new TutorialShopsAndInns(),
            new TutorialCrafting(),
            new TutorialQuests(),
            new TutorialSaveFiles(),
            new TutorialPlayerProfiles(),
            new TutorialDialogues(),
            new TutorialAudio(),
            new TutorialCommands(),
            new TutorialGameFlags(),
            new TutorialGameManager(),
            new TutorialGameSystems(),
            new TutorialNavigationCursors(),
            new TutorialConditionalActivators(),
        };

        private int m_selectedTab = 0;
        private Vector2 m_scrollPosition;

        [MenuItem("Window/Mythril2D/Tutorials")]
        public static void ShowWindow()
        {
            EditorWindow window = GetWindow<TutorialsWindow>();
            window.titleContent = new GUIContent("Tutorials");
            window.Show();
        }

        private string GetFormattedTutorialContent(int index)
        {
            ITutorial tutorial = m_tutorials[index];
            string content = string.Empty;
            content += $"<color=#FFC300><size=18><b>{tutorial.Title}</b></size></color>\n";
            content += $"<i>{tutorial.Description}</i>\n";
            foreach (var paragraph in tutorial.Paragraphs)
            {
                content += $"\n{paragraph}\n";
            }

            return content;
        }    

        private void OnGUI()
        {
            minSize = new Vector2(900.0f, 600.0f);

            GUILayout.BeginVertical();

            GUILayout.Label("Learn about Mythril2D by reading these tutorials!", new GUIStyle(EditorStyles.boldLabel)
            {
                richText = true,
                fontSize = 18,
                alignment = TextAnchor.MiddleCenter,
                padding = new RectOffset(5, 5, 5, 5),
                wordWrap = true
            });

            GUILayout.Space(10);


            m_selectedTab = GUILayout.SelectionGrid(m_selectedTab, m_tutorials.Select(tutorial => tutorial.Title).ToArray(), 6);

            if (m_selectedTab >= 0)
            {
                GUILayout.Space(10);
                m_scrollPosition = GUILayout.BeginScrollView(m_scrollPosition);
                GUIStyle style = new GUIStyle(GUI.skin.box);
                style.stretchWidth = true;
                style.stretchHeight = true;
                style.normal = style.active;
                GUILayout.Label(GetFormattedTutorialContent(m_selectedTab), new GUIStyle(style)
                {
                    richText = true,
                    padding = new RectOffset(5, 5, 5, 5),
                    margin = new RectOffset(5, 5, 5, 5),
                    fontSize = 14,
                    alignment = TextAnchor.UpperLeft,
                    wordWrap = true
                });

                GUILayout.EndScrollView();
                GUILayout.Space(10);
            }

            GUILayout.EndVertical();
        }
    }
}
