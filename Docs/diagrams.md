# Evil Forces - System Diagrams

This document contains Mermaid diagrams that visualize the various systems and architecture of Evil Forces.

## 1. Game Architecture Overview

```mermaid
graph TB
    subgraph "Client Layer"
        C1[Player Client 1]
        C2[Player Client 2]
        C3[Player Client N]
    end
    
    subgraph "Server Infrastructure"
        OWS[Open World Server<br/>Backend & Orchestration]
        Hub1[Hub Server<br/>Rule Town]
        Hub2[Hub Server<br/>Future Towns]
        MG1[Minigame Server<br/>Food Fighters]
        MG2[Minigame Server<br/>Robot Fighters]
        Adv1[Adventure Server<br/>Haunted Village]
        Adv2[Adventure Server<br/>Dark Carnival]
    end
    
    subgraph "Data Layer"
        DB[(Player Database)]
        CDN[Content CDN]
        Analytics[Analytics Engine]
    end
    
    C1 --> OWS
    C2 --> OWS
    C3 --> OWS
    
    OWS --> Hub1
    OWS --> Hub2
    OWS --> MG1
    OWS --> MG2
    OWS --> Adv1
    OWS --> Adv2
    
    OWS --> DB
    OWS --> Analytics
    Hub1 --> CDN
    Hub2 --> CDN
```

## 2. Player Progression Flow

```mermaid
flowchart TD
    Start[New Player] --> Tutorial[Tutorial & Onboarding]
    Tutorial --> ChooseClass[Choose Archetype<br/>Arcana/Warfare/Tech]
    ChooseClass --> StartHouse[Get Starting House]
    StartHouse --> TownLife[Explore Town & Socialize]
    
    TownLife --> Jobs[Complete Jobs<br/>Earn Currency]
    TownLife --> Minigames[Join Minigames<br/>Food Fighters/Robot Fighters]
    TownLife --> Adventure[Explore Adventure Zones<br/>Haunted Village/Dark Carnival]
    
    Jobs --> Crafting[Craft Items & Materials]
    Adventure --> Resources[Gather Resources<br/>Souls/Candy/Materials]
    
    Crafting --> Minigames
    Resources --> Crafting
    
    Minigames --> Progression[Character Progression<br/>Level Up & Unlock Abilities]
    Adventure --> Progression
    Jobs --> Progression
    
    Progression --> AdvancedContent[Advanced Content<br/>Higher Level Zones & Challenges]
    AdvancedContent --> EndGame[End Game Content<br/>Dragon's Dream Raid]
    
    style Start fill:#e1f5fe
    style EndGame fill:#ffebee
    style Progression fill:#f3e5f5
```

## 3. Minigame Systems Integration

```mermaid
graph LR
    subgraph "Adventure Zones"
        HV[Haunted Village<br/>Souls]
        DC[Dark Carnival<br/>Haunted Candy]
        CL[Candy Land<br/>Sweet Materials]
    end
    
    subgraph "Crafting Systems"
        FC[Food Crafting<br/>Monsters]
        RC[Robot Crafting<br/>Mechs]
        GC[General Crafting<br/>Equipment]
    end
    
    subgraph "Minigames"
        FF[Food Fighters<br/>Pokémon-style Combat]
        RF[Robot Fighters<br/>Mech Combat]
        SF[Snowball Fight<br/>Seasonal]
        FA[Fort Attack<br/>Base Building]
    end
    
    HV --> FC
    DC --> FC
    CL --> FC
    
    HV --> RC
    DC --> RC
    CL --> RC
    
    FC --> FF
    RC --> RF
    
    GC --> SF
    GC --> FA
    
    style FF fill:#e8f5e8
    style RF fill:#e8f5e8
    style FC fill:#fff3e0
    style RC fill:#fff3e0
```

## 4. Character Archetype System

```mermaid
graph TD
    subgraph "Base Archetypes"
        Arcana[Arcana<br/>Magic & Spells]
        Warfare[Warfare<br/>Combat & Weapons]
        Tech[Tech<br/>Gadgets & Cybernetics]
    end
    
    subgraph "Arcana Specializations"
        Necro[Necromancer<br/>Undead & Death Magic]
        Elemental[Elementalist<br/>Fire/Ice/Lightning]
        Healer[Healer<br/>Support & Restoration]
    end
    
    subgraph "Warfare Specializations"
        Sniper[Sniper<br/>Precision & Range]
        Tank[Tank<br/>Defense & Protection]
        Assault[Assault<br/>Close Combat]
    end
    
    subgraph "Tech Specializations"
        Engineer[Engineer<br/>Construction & Repair]
        Hacker[Hacker<br/>Digital & Control]
        Infiltrator[Infiltrator<br/>Stealth & Sabotage]
    end
    
    Arcana --> Necro
    Arcana --> Elemental
    Arcana --> Healer
    
    Warfare --> Sniper
    Warfare --> Tank
    Warfare --> Assault
    
    Tech --> Engineer
    Tech --> Hacker
    Tech --> Infiltrator
    
    style Arcana fill:#e3f2fd
    style Warfare fill:#ffebee
    style Tech fill:#f3e5f5
```

## 5. Social & Housing Systems

```mermaid
graph TB
    subgraph "Player Housing"
        House[Player House<br/>Customizable Space]
        Workshop[Personal Workshop<br/>Crafting Stations]
        Storage[Secure Storage<br/>Items & Materials]
        Garden[Exterior Garden<br/>Decorations & Plants]
    end
    
    subgraph "Social Systems"
        Friends[Friends List<br/>Direct Communication]
        Guilds[Guilds<br/>Organized Groups]
        Neighborhoods[Neighborhoods<br/>Geographic Communities]
        Parties[Temporary Parties<br/>Adventure Groups]
    end
    
    subgraph "Communication"
        VoiceChat[Voice Chat<br/>Proximity & Party]
        TextChat[Text Chat<br/>Local/Global/Private]
        Emotes[Emotes & Gestures<br/>Non-verbal Communication]
        SocialMedia[Social Media Integration<br/>Sharing & Events]
    end
    
    House --> Workshop
    House --> Storage
    House --> Garden
    
    Friends --> VoiceChat
    Guilds --> TextChat
    Neighborhoods --> Emotes
    Parties --> VoiceChat
    
    style House fill:#e8f5e8
    style Friends fill:#fff3e0
    style VoiceChat fill:#e3f2fd
```

## 6. Economy & Progression Systems

```mermaid
flowchart LR
    subgraph "Income Sources"
        Jobs[Jobs<br/>Mini-games for Coins]
        Trading[Trading<br/>Player-to-Player Sales]
        Tournaments[Tournaments<br/>Competition Prizes]
        Services[Services<br/>Skills & Assistance]
    end
    
    subgraph "Currencies"
        Coins[Coins<br/>Basic Currency]
        Gems[Gems<br/>Premium Currency]
        Reputation[Reputation<br/>Community Standing]
        CraftingPoints[Crafting Points<br/>Specialized Currency]
    end
    
    subgraph "Spending Categories"
        Equipment[Equipment<br/>Weapons & Armor]
        Housing[Housing<br/>Furniture & Upgrades]
        Crafting[Crafting<br/>Materials & Tools]
        Convenience[Convenience<br/>Time-savers & QoL]
    end
    
    Jobs --> Coins
    Trading --> Coins
    Tournaments --> Gems
    Services --> Reputation
    
    Coins --> Equipment
    Coins --> Housing
    Gems --> Convenience
    Reputation --> Crafting
    
    style Coins fill:#fff9c4
    style Gems fill:#e1bee7
    style Equipment fill:#c8e6c9
```

## 7. World Events & Dynamic Content

```mermaid
graph TD
    subgraph "Local Events"
        Snowball[Snowball Fight<br/>Seasonal Competition]
        MarketSale[Market Sale<br/>Limited-time Discounts]
        Festival[Festival<br/>Themed Celebrations]
    end
    
    subgraph "Global Events"
        ThreatEvent[Threat Event<br/>"Necromancer in 5 days"]
        Discovery[Discovery Event<br/>New Areas Appear]
        Community[Community Challenge<br/>Server-wide Goals]
    end
    
    subgraph "Event Triggers"
        Time[Time-based<br/>Scheduled Events]
        PlayerAction[Player Actions<br/>Community Milestones]
        ServerState[Server State<br/>Population/Activity]
        Random[Random<br/>Unexpected Events]
    end
    
    Time --> Snowball
    Time --> MarketSale
    Time --> Festival
    
    PlayerAction --> ThreatEvent
    ServerState --> Discovery
    Random --> Community
    
    style ThreatEvent fill:#ffcdd2
    style Discovery fill:#c8e6c9
    style Community fill:#bbdefb
```

## 8. Quest & Mission Flow

```mermaid
flowchart TD
    subgraph "Quest Types"
        Story[Story Quests<br/>Main Plotline]
        Side[Side Quests<br/>NPC Requests]
        Daily[Daily Quests<br/>Regular Activities]
        Weekly[Weekly Challenges<br/>Extended Objectives]
    end
    
    subgraph "Quest Structure"
        Objectives[Clear Objectives<br/>Measurable Goals]
        Rewards[Rewards<br/>XP/Currency/Items]
        TimeLimit[Time Limits<br/>Some Have Deadlines]
        Scaling[Difficulty Scaling<br/>Player Level/Group Size]
    end
    
    subgraph "Quest Progression"
        Tracking[Progress Tracking<br/>Clear Indication]
        MultiplePaths[Multiple Paths<br/>Different Solutions]
        Choices[Branching Choices<br/>Affect Outcomes]
        Consequences[Consequences<br/>Impact Future Quests]
    end
    
    Story --> Objectives
    Side --> Rewards
    Daily --> TimeLimit
    Weekly --> Scaling
    
    Objectives --> Tracking
    Rewards --> MultiplePaths
    TimeLimit --> Choices
    Scaling --> Consequences
    
    style Story fill:#e1f5fe
    style Daily fill:#f3e5f5
    style Consequences fill:#ffebee
```

## 9. Technical Performance Requirements

```mermaid
graph LR
    subgraph "Client Performance"
        FPS[60 FPS Target<br/>Recommended Hardware]
        Loading[< 30s Loading<br/>Zone Transitions]
        Memory[Memory Management<br/>Efficient Asset Streaming]
        Network[Network Optimization<br/>Minimal Bandwidth]
    end
    
    subgraph "Server Performance"
        Concurrent[1000+ Players<br/>Per Server Instance]
        Latency[< 100ms Latency<br/>Competitive Gameplay]
        Uptime[99.5% Uptime<br/>Target]
        Scaling[Horizontal Scaling<br/>Load Distribution]
    end
    
    subgraph "Network Performance"
        Bandwidth[Bandwidth Optimization<br/>Efficient Data Transmission]
        PacketLoss[Packet Loss Handling<br/>Error Recovery]
        Stability[Connection Stability<br/>Reliable Connectivity]
        Global[Cross-Region Play<br/>Global Distribution]
    end
    
    FPS --> Concurrent
    Loading --> Latency
    Memory --> Uptime
    Network --> Scaling
    
    style FPS fill:#c8e6c9
    style Latency fill:#ffcdd2
    style Uptime fill:#fff9c4
```

## 10. Development Pipeline

```mermaid
graph TB
    subgraph "Asset Creation"
        Modeling[3D Modeling<br/>Maya/Blender]
        Texturing[Texturing<br/>Substance Painter]
        Animation[Animation<br/>Maya/Blender]
        Audio[Audio<br/>Wwise/FMOD]
    end
    
    subgraph "Development"
        Code[C++ Development<br/>Core Systems]
        Blueprint[Blueprint Scripting<br/>Gameplay Logic]
        Testing[Testing<br/>Unit/Integration/Performance]
        Review[Code Review<br/>Quality Assurance]
    end
    
    subgraph "Build & Deploy"
        Build[Automated Builds<br/>CI/CD Pipeline]
        Package[Game Packaging<br/>Asset Cooking]
        Deploy[Deployment<br/>Staging/Production]
        Monitor[Monitoring<br/>Performance & Errors]
    end
    
    Modeling --> Code
    Texturing --> Blueprint
    Animation --> Testing
    Audio --> Review
    
    Code --> Build
    Blueprint --> Package
    Testing --> Deploy
    Review --> Monitor
    
    style Build fill:#e8f5e8
    style Deploy fill:#ffebee
    style Monitor fill:#e3f2fd
```

These diagrams provide visual representations of the key systems and relationships in Evil Forces. They can be used for:

1. **Team Communication:** Clear visualization of system interactions
2. **Development Planning:** Understanding dependencies and requirements
3. **Documentation:** Visual aids for technical and design documentation
4. **Stakeholder Presentations:** Easy-to-understand system overviews
5. **Onboarding:** New team member orientation and understanding

The diagrams can be updated as the design evolves and new systems are added to the game. 