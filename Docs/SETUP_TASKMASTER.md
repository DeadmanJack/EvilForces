# Task Master AI Setup Guide

This guide explains how to set up Task Master AI for the Evil Forces project.

## 🔑 Required API Keys

You'll need at least one of these API keys to use Task Master AI:

### Anthropic (Claude) - Recommended
- Visit: https://console.anthropic.com/
- Create an account and get your API key
- Key format: `sk-ant-api03-...`

### Perplexity - For Research Features
- Visit: https://www.perplexity.ai/settings/api
- Create an account and get your API key
- Key format: `pplx-...`

## 📁 Setup Steps

### 1. Copy Template Files
```bash
# Copy MCP configuration template
cp .cursor/mcp.json.template .cursor/mcp.json

# Copy Task Master AI configuration template
cp .taskmaster/config.json.template .taskmaster/config.json
```

### 2. Update API Keys
Edit `.cursor/mcp.json` and replace the placeholder values:
```json
{
  "env": {
    "ANTHROPIC_API_KEY": "your_actual_anthropic_key_here",
    "PERPLEXITY_API_KEY": "your_actual_perplexity_key_here"
  }
}
```

### 3. Update Task Master AI Config
Edit `.taskmaster/config.json` and update:
- `projectName`: Your project name
- `userId`: Your user ID (can be any unique identifier)

### 4. Restart Cursor
Restart Cursor to reload the MCP configuration.

## 🧪 Test Setup

Run these commands to test your setup:

```bash
# List all tasks
npx task-master-ai list

# Show next task
npx task-master-ai next

# Expand a task (requires API keys)
npx task-master-ai expand --id=21
```

## 📝 Notes

- The original files with real API keys are ignored by git for security
- Template files are safe to commit to version control
- Each developer needs to set up their own API keys
- Free tiers are available for both Anthropic and Perplexity

## 🆘 Troubleshooting

If you get API key errors:
1. Check that your API keys are correct
2. Verify you have credits/balance in your API provider account
3. Restart Cursor after updating configuration
4. Check the Task Master AI logs for detailed error messages 