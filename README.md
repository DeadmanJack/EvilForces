# Evil Forces - Multiplayer FPS/TPS RPG

A semi-open world multiplayer FPS/TPS RPG where players explore a mysterious world affected by a sleeping dragon's dreams. Players live in a social hub town, participate in unique minigames like "Food Fighters," and adventure through themed zones to gather resources and craft powerful monsters.

## 🎮 Project Overview

### Core Concept
- **Social Hub Living**: Persistent town environment with player housing and social interactions
- **Integrated Crafting & Combat**: Minigames require adventure and crafting components
- **Living World Events**: Dynamic events that affect the entire community
- **Multi-layered Progression**: Character, crafting, and base building advancement

### Key Features
- **Main Town "Rule"**: Fully functional town with player housing, social spaces, and NPCs
- **Food Fighters Minigame**: Pokémon-style combat with crafted food monsters
- **Adventure Zones**: Haunted Village and Dark Carnival for resource gathering
- **Character System**: Three archetypes (Arcana, Warfare, Tech) with skill trees
- **Crafting System**: Material gathering and monster creation for minigames
- **Base Building**: House customization and expansion
- **Quest System**: Main quest line and side quests

## 🚀 Getting Started

### Prerequisites
- **Unreal Engine 5.3+**: Latest stable version
- **Git**: For version control
- **Node.js**: For Task Master AI (optional but recommended)
- **API Keys**: For Task Master AI features (see setup guide below)

### Installation
1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd EvilForces
   ```

2. Open the project in Unreal Engine 5.3+

3. Set up Task Master AI (see section below)

4. Build the project:
   ```bash
   # In Unreal Engine: Build > Build Solution
   ```

## 🤖 Task Master AI Setup

Task Master AI helps manage the 8-month demo development timeline with detailed task tracking and dependencies.

### Required API Keys

You'll need at least one of these API keys to use Task Master AI:

#### Anthropic (Claude) - Recommended
- Visit: https://console.anthropic.com/
- Create an account and get your API key
- Key format: `sk-ant-api03-...`

#### Perplexity - For Research Features
- Visit: https://www.perplexity.ai/settings/api
- Create an account and get your API key
- Key format: `pplx-...`

### Setup Steps

1. **Copy Template Files**:
   ```bash
   # Copy MCP configuration template
   cp .cursor/mcp.json.template .cursor/mcp.json
   
   # Copy Task Master AI configuration template
   cp .taskmaster/config.json.template .taskmaster/config.json
   ```

2. **Update API Keys**:
   Edit `.cursor/mcp.json` and replace the placeholder values:
   ```json
   {
     "env": {
       "ANTHROPIC_API_KEY": "your_actual_anthropic_key_here",
       "PERPLEXITY_API_KEY": "your_actual_perplexity_key_here"
     }
   }
   ```

3. **Update Task Master AI Config**:
   Edit `.taskmaster/config.json` and update:
   - `projectName`: Your project name
   - `userId`: Your user ID (can be any unique identifier)

4. **Restart Cursor**:
   Restart Cursor to reload the MCP configuration.

### Testing Task Master AI

```bash
# List all tasks
npx task-master-ai list

# Show next task
npx task-master-ai next

# Show specific task details
npx task-master-ai show 21

# Expand a task into subtasks (requires API keys)
npx task-master-ai expand --id=21

# Mark task as in progress
npx task-master-ai set-status --id=21 --status=in-progress

# Mark task as done
npx task-master-ai set-status --id=21 --status=done
```

### Troubleshooting

If you get API key errors:
1. Check that your API keys are correct
2. Verify you have credits/balance in your API provider account
3. Restart Cursor after updating configuration
4. Check the Task Master AI logs for detailed error messages

## 📋 Development Timeline

### 8-Month Demo Development Plan

The project is organized into 60 detailed tasks covering:

#### Phase 1: Foundation (Tasks 21-27)
- UE5 project setup
- Core systems (networking, UI, save system)
- Character base classes
- Day/night cycle

#### Phase 2: Core Systems (Tasks 28-44)
- Inventory and crafting systems
- Base building framework
- Combat system (Tech archetype focus)
- Enemy AI and types

#### Phase 3: Content (Tasks 45-58)
- Food Fighters minigame
- Quest system
- NPC system
- Adventure zones (Haunted Village, Dark Carnival)

#### Phase 4: Polish & Demo (Tasks 59-80)
- Job system
- Tutorial system
- Performance optimization
- Final integration and testing

### Current Status
- **Total Tasks**: 60
- **Completed**: 0
- **In Progress**: 0
- **Pending**: 60

## 🏗️ Project Structure

```
EvilForces/
├── .taskmaster/              # Task Master AI configuration
│   ├── tasks/               # Task files and tracking
│   ├── docs/                # Project documentation
│   └── config.json          # Task Master AI settings
├── .cursor/                 # Cursor IDE configuration
│   └── mcp.json            # MCP server configuration
├── Content/                 # Unreal Engine content
│   ├── Characters/         # Character assets
│   ├── ThirdPerson/        # Third-person template
│   └── Variant_*/          # Game variant content
├── Source/                  # C++ source code
│   └── EvilForces/         # Main game module
├── Docs/                    # Project documentation
│   ├── PRD_EvilForces.md   # Product Requirements Document
│   ├── GDD_EvilForces.md   # Game Design Document
│   └── Demo_Requirements.md # Demo specifications
└── Config/                  # Unreal Engine configuration
```

## 🎯 Demo Requirements

### Target Features
- **Main Town "Rule"**: 10-15 player houses, social spaces, NPCs
- **Food Fighters**: 5-8 monster types, 3 battle environments
- **Inventory System**: 50+ items, crafting materials, storage
- **Base Building**: 30+ furniture pieces, 3 house styles
- **Combat System**: 8-10 weapons, 6-8 enemy types
- **Adventure Zones**: Haunted Village and Dark Carnival
- **Quest System**: 5-6 main quests, 10-15 side quests

### Technical Requirements
- **Performance**: 60 FPS with 50+ concurrent players
- **Loading**: < 30 seconds initial load time
- **Networking**: < 100ms latency for competitive gameplay
- **Crash Rate**: < 1% crash rate

## 🔧 Development Guidelines

### Code Standards
- Follow Unreal Engine 5 coding standards
- Use Gameplay Ability System (GAS) for abilities
- Implement State Tree for AI systems
- Use Niagara for particle effects
- Use MetaSounds for audio systems

### Asset Guidelines
- Follow the Art Guide in `Docs/Art_Guide_EvilForces.md`
- Use appropriate LOD systems for performance
- Implement proper asset streaming
- Follow naming conventions

### Testing Strategy
- Test all features in multiplayer environment
- Validate performance targets regularly
- Use Task Master AI to track testing progress
- Document bugs and issues in task system

## 📚 Documentation

### Key Documents
- **PRD_EvilForces.md**: Product Requirements Document
- **GDD_EvilForces.md**: Game Design Document
- **Demo_Requirements.md**: Demo specifications and requirements
- **Art_Guide_EvilForces.md**: Art style and asset guidelines
- **tech_info.md**: Technical implementation details

### Architecture
- **EvilForces_ServerArchitecture.md**: Server architecture overview
- **OWS_vs_Epic_MultiServer_Comparison.md**: Server solution comparison

## 🤝 Contributing

### Development Workflow
1. Use Task Master AI to track your work
2. Create feature branches for major changes
3. Test thoroughly in multiplayer environment
4. Update task status as you complete work
5. Document any new systems or changes

### Code Review
- All code changes require review
- Test multiplayer functionality
- Verify performance impact
- Update documentation as needed

## 📊 Progress Tracking

### Task Master AI Commands
```bash
# View current progress
npx task-master-ai list

# See what to work on next
npx task-master-ai next

# Check task dependencies
npx task-master-ai show <task-id>

# Update task progress
npx task-master-ai set-status --id=<task-id> --status=<status>
```

### Status Options
- `pending`: Task is ready to be worked on
- `in-progress`: Currently being worked on
- `done`: Completed and tested
- `review`: Ready for review
- `deferred`: Postponed for later
- `cancelled`: No longer needed

## 🐛 Known Issues

- API key configuration issues with Task Master AI
- Performance optimization needed for large player counts
- Networking synchronization for complex systems

## 📞 Support

### Getting Help
- Check the documentation in the `Docs/` folder
- Use Task Master AI to track issues and progress
- Review the troubleshooting section in this README

### Team Communication
- Use Task Master AI for task coordination
- Document decisions and changes
- Keep task status updated

## 📄 License

[Add your license information here]

## 🙏 Acknowledgments

- Unreal Engine team for the excellent engine
- Task Master AI for project management tools
- [Add other acknowledgments as needed] 