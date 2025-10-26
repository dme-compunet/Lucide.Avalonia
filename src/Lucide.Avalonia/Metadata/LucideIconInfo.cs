namespace Lucide.Avalonia.Metadata;

public class LucideIconInfo
{
    public required LucideIconKind Kind { get; init; }

    public required string[] Contributors { get; init; }

    public required string[] Categories { get; init; }

    public required string[] Tags { get; init; }

    public bool Contains(string? value, out int priority)
    {
        priority = 0;

        if (string.IsNullOrEmpty(value))
        {
            return true;
        }

        value = value.ToLower();

        var kind = Kind.ToString().ToLower();

        if (kind == value)
        {
            return true;
        }

        if (kind.StartsWith(value))
        {
            priority = 1;
            return true;
        }

        if (kind.Contains(value))
        {
            priority = 2;
            return true;
        }

        foreach (var category in Categories)
        {
            if (category.Contains(value))
            {
                priority = 3;
                return true;
            }
        }

        foreach (var tag in Tags)
        {
            if (tag.Contains(value))
            {
                priority = 4;
                return true;
            }
        }

        return false;
    }

    public static LucideIconInfo GetIconInfo(LucideIconKind kind)
    {
        return kind switch
        {
            LucideIconKind.AArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "jguddas", "danielbayley", "ericfennis"],
                Categories = ["text", "design"],
                Tags = ["letter", "font size", "text", "formatting", "smaller"],
            },
            LucideIconKind.AArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "jguddas", "danielbayley", "ericfennis"],
                Categories = ["text", "design"],
                Tags = ["letter", "font size", "text", "formatting", "larger", "bigger"],
            },
            LucideIconKind.ALargeSmall => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "jguddas", "danielbayley", "ericfennis", "vichotech", "karsa-mistmere"],
                Categories = ["text", "design"],
                Tags = ["letter", "font size", "text", "formatting"],
            },
            LucideIconKind.Accessibility => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["accessibility", "medical"],
                Tags = ["disability", "disabled", "dda", "wheelchair"],
            },
            LucideIconKind.Activity => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["medical", "account", "social", "science", "multimedia"],
                Tags = ["pulse", "action", "motion", "movement", "exercise", "fitness", "healthcare", "heart rate monitor", "vital signs", "vitals", "emergency room", "er", "intensive care", "hospital", "defibrillator", "earthquake", "siesmic", "magnitude", "richter scale", "aftershock", "tremor", "shockwave", "audio", "waveform", "synthesizer", "synthesiser", "music"],
            },
            LucideIconKind.AirVent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["home"],
                Tags = ["air conditioner", "ac", "central air", "cooling", "climate-control"],
            },
            LucideIconKind.Airplay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["multimedia", "connectivity", "devices", "brands"],
                Tags = ["stream", "cast", "mirroring", "screen", "monitor", "macos", "osx"],
            },
            LucideIconKind.AlarmClock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "johnletey", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["devices", "notifications", "time"],
                Tags = ["morning"],
            },
            LucideIconKind.AlarmClockCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["devices", "notifications", "time"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.AlarmClockMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["devices", "notifications", "time"],
                Tags = ["remove"],
            },
            LucideIconKind.AlarmClockOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["devices", "notifications", "time"],
                Tags = ["morning", "turn-off"],
            },
            LucideIconKind.AlarmClockPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["devices", "notifications", "time"],
                Tags = ["add"],
            },
            LucideIconKind.AlarmSmoke => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["home", "devices", "travel"],
                Tags = ["fire", "alert", "warning", "detector", "carbon monoxide", "safety", "equipment", "amenities"],
            },
            LucideIconKind.Album => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "mittalyashu"],
                Categories = ["photography", "multimedia"],
                Tags = ["photo", "book"],
            },
            LucideIconKind.AlignCenterHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify"],
            },
            LucideIconKind.AlignCenterVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify"],
            },
            LucideIconKind.AlignEndHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "bottom", "flex", "justify"],
            },
            LucideIconKind.AlignEndVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "right", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalDistributeCenter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["r4lv", "ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify", "space", "evenly", "around"],
            },
            LucideIconKind.AlignHorizontalDistributeEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["r4lv", "ericfennis"],
                Categories = ["layout"],
                Tags = ["right", "items", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalDistributeStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["r4lv", "ericfennis"],
                Categories = ["layout"],
                Tags = ["left", "items", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalJustifyCenter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["center", "items", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalJustifyEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["right", "items", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalJustifyStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["left", "items", "flex", "justify"],
            },
            LucideIconKind.AlignHorizontalSpaceAround => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["center", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.AlignHorizontalSpaceBetween => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["around", "items", "bottom", "flex", "justify"],
            },
            LucideIconKind.AlignStartHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["top", "items", "flex", "justify"],
            },
            LucideIconKind.AlignStartVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["left", "items", "flex", "justify"],
            },
            LucideIconKind.AlignVerticalDistributeCenter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify", "space", "evenly", "around"],
            },
            LucideIconKind.AlignVerticalDistributeEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["bottom", "items", "flex", "justify"],
            },
            LucideIconKind.AlignVerticalDistributeStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["top", "items", "flex", "justify"],
            },
            LucideIconKind.AlignVerticalJustifyCenter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["center", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.AlignVerticalJustifyEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["bottom", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.AlignVerticalJustifyStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["top", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.AlignVerticalSpaceAround => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["center", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.AlignVerticalSpaceBetween => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["center", "items", "flex", "justify", "distribute", "between"],
            },
            LucideIconKind.Ambulance => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jordan808", "jguddas", "colebemis", "ahtohbi4", "ericfennis", "Andreto", "csandman", "karsa-mistmere", "danielbayley"],
                Categories = ["medical", "transportation"],
                Tags = ["ambulance", "emergency", "medical", "vehicle", "siren", "healthcare", "transportation", "rescue", "urgent", "first aid"],
            },
            LucideIconKind.Ampersand => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["and", "typography", "operator", "join", "concatenate", "code", "&"],
            },
            LucideIconKind.Ampersands => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["and", "operator", "then", "code", "&&"],
            },
            LucideIconKind.Amphora => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage", "gaming"],
                Tags = ["pottery", "artifact", "artefact", "vase", "ceramics", "clay", "archaeology", "museum", "wine", "oil"],
            },
            LucideIconKind.Anchor => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["transportation", "text"],
                Tags = ["ship"],
            },
            LucideIconKind.Angry => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["emoji"],
                Tags = ["emoji", "anger", "face", "emotion"],
            },
            LucideIconKind.Annoyed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["emoji"],
                Tags = ["emoji", "nuisance", "face", "emotion"],
            },
            LucideIconKind.Antenna => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "multimedia", "communication"],
                Tags = ["signal", "connection", "connectivity", "tv", "television", "broadcast", "live", "frequency", "tune", "scan", "channels", "aerial", "receiver", "transmission", "transducer", "terrestrial", "satellite", "cable"],
            },
            LucideIconKind.Anvil => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["buildings", "tools", "gaming"],
                Tags = ["metal", "iron", "alloy", "materials", "heavy", "weight", "blacksmith", "forge", "acme"],
            },
            LucideIconKind.Aperture => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["photography"],
                Tags = ["camera", "photo", "pictures", "shutter", "exposure"],
            },
            LucideIconKind.AppWindow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["layout", "design", "development", "files"],
                Tags = ["application", "menu bar", "pane", "executable"],
            },
            LucideIconKind.AppWindowMac => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "files"],
                Tags = ["application", "menu bar", "pane", "preferences", "macos", "osx", "executable"],
            },
            LucideIconKind.Apple => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["fruit", "food", "healthy", "snack", "nutrition", "fresh", "produce", "grocery", "organic", "harvest", "vitamin", "red", "green", "juicy", "sweet", "tart", "bite", "orchard", "plant", "core", "raw", "diet"],
            },
            LucideIconKind.Archive => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files", "mail"],
                Tags = ["index", "backup", "box", "storage", "records"],
            },
            LucideIconKind.ArchiveRestore => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files", "mail"],
                Tags = ["unarchive", "index", "backup", "box", "storage", "records"],
            },
            LucideIconKind.ArchiveX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files", "mail"],
                Tags = ["index", "backup", "box", "storage", "records", "junk"],
            },
            LucideIconKind.Armchair => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["home"],
                Tags = ["sofa", "furniture", "leisure", "lounge", "loveseat", "couch"],
            },
            LucideIconKind.ArrowBigDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["backwards", "reverse", "direction", "south"],
            },
            LucideIconKind.ArrowBigDownDash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming", "files"],
                Tags = ["backwards", "reverse", "slow", "direction", "south", "download"],
            },
            LucideIconKind.ArrowBigLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "ericfennis", "danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["previous", "back", "direction", "west", "indicate turn"],
            },
            LucideIconKind.ArrowBigLeftDash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["previous", "back", "direction", "west", "turn", "corner"],
            },
            LucideIconKind.ArrowBigRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "ericfennis", "danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["next", "forward", "direction", "east", "indicate turn"],
            },
            LucideIconKind.ArrowBigRightDash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["next", "forward", "direction", "east", "turn", "corner"],
            },
            LucideIconKind.ArrowBigUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "text", "development", "gaming"],
                Tags = ["shift", "keyboard", "button", "mac", "capitalize", "capitalise", "forward", "direction", "north"],
            },
            LucideIconKind.ArrowBigUpDash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "navigation", "text", "development", "gaming"],
                Tags = ["caps lock", "capitals", "keyboard", "button", "mac", "forward", "direction", "north", "faster", "speed", "boost"],
            },
            LucideIconKind.ArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["backwards", "reverse", "direction", "south"],
            },
            LucideIconKind.ArrowDown01 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "numerical"],
            },
            LucideIconKind.ArrowDown10 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "numerical"],
            },
            LucideIconKind.ArrowDownAZ => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "alphabetical"],
            },
            LucideIconKind.ArrowDownFromLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "files"],
                Tags = ["backwards", "reverse", "direction", "south", "download", "expand", "fold", "vertical"],
            },
            LucideIconKind.ArrowDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "south-west", "diagonal"],
            },
            LucideIconKind.ArrowDownNarrowWide => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ArrowDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "south-east", "diagonal"],
            },
            LucideIconKind.ArrowDownToDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "south", "waypoint", "location", "step", "into"],
            },
            LucideIconKind.ArrowDownToLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "files", "development"],
                Tags = ["behind", "direction", "south", "download", "save", "git", "version control", "pull", "collapse", "fold", "vertical"],
            },
            LucideIconKind.ArrowDownUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["arrows", "navigation"],
                Tags = ["bidirectional", "two-way", "2-way", "swap", "switch", "network", "traffic", "flow", "mobile data", "internet", "sort", "reorder", "move"],
            },
            LucideIconKind.ArrowDownWideNarrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ArrowDownZA => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "alphabetical", "reverse"],
            },
            LucideIconKind.ArrowLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["previous", "back", "direction", "west", "<-"],
            },
            LucideIconKind.ArrowLeftFromLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["previous", "back", "direction", "west", "expand", "fold", "horizontal", "<-|"],
            },
            LucideIconKind.ArrowLeftRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["bidirectional", "two-way", "2-way", "swap", "switch", "transaction", "reorder", "move", "<-", "->"],
            },
            LucideIconKind.ArrowLeftToLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["previous", "back", "direction", "west", "collapse", "fold", "horizontal", "|<-"],
            },
            LucideIconKind.ArrowRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["forward", "next", "direction", "east", "->"],
            },
            LucideIconKind.ArrowRightFromLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["next", "forward", "direction", "east", "export", "expand", "fold", "horizontal", "|->"],
            },
            LucideIconKind.ArrowRightLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["arrows", "navigation"],
                Tags = ["bidirectional", "two-way", "2-way", "swap", "switch", "transaction", "reorder", "move", "<-", "->"],
            },
            LucideIconKind.ArrowRightToLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "development"],
                Tags = ["next", "forward", "direction", "east", "tab", "keyboard", "mac", "indent", "collapse", "fold", "horizontal", "->|"],
            },
            LucideIconKind.ArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["forward", "direction", "north"],
            },
            LucideIconKind.ArrowUp01 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "numerical"],
            },
            LucideIconKind.ArrowUp10 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "numerical"],
            },
            LucideIconKind.ArrowUpAZ => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "alphabetical"],
            },
            LucideIconKind.ArrowUpDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "karsa-mistmere", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["bidirectional", "two-way", "2-way", "swap", "switch", "network", "mobile data", "internet", "sort", "reorder", "move"],
            },
            LucideIconKind.ArrowUpFromDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "north", "step", "out"],
            },
            LucideIconKind.ArrowUpFromLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "files", "development"],
                Tags = ["forward", "direction", "north", "upload", "git", "version control", "push", "expand", "fold", "vertical"],
            },
            LucideIconKind.ArrowUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "north-west", "diagonal"],
            },
            LucideIconKind.ArrowUpNarrowWide => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lukesmurray", "ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ArrowUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "north-east", "diagonal"],
            },
            LucideIconKind.ArrowUpToLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "files"],
                Tags = ["forward", "direction", "north", "upload", "collapse", "fold", "vertical"],
            },
            LucideIconKind.ArrowUpWideNarrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ArrowUpZA => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text", "layout", "arrows"],
                Tags = ["filter", "sort", "ascending", "descending", "increasing", "decreasing", "rising", "falling", "alphabetical", "reverse"],
            },
            LucideIconKind.ArrowsUpFromLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "transportation", "mail"],
                Tags = ["direction", "orientation", "this way up", "vertical", "package", "box", "fragile", "postage", "shipping"],
            },
            LucideIconKind.Asterisk => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["text", "math", "development"],
                Tags = ["reference", "times", "multiply", "multiplication", "operator", "code", "glob pattern", "wildcard", "*"],
            },
            LucideIconKind.AtSign => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley"],
                Categories = ["text", "account"],
                Tags = ["mention", "at", "email", "message", "@"],
            },
            LucideIconKind.Atom => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["science"],
                Tags = ["atomic", "nuclear", "physics", "particle", "element", "molecule", "electricity", "energy", "chemistry"],
            },
            LucideIconKind.AudioLines => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "communication"],
                Tags = ["graphic equaliser", "sound", "noise", "listen", "hearing", "hertz", "frequency", "wavelength", "vibrate", "sine", "synthesizer", "synthesiser", "levels", "track", "music", "playback", "radio", "broadcast", "airwaves", "voice", "vocals", "singer", "song"],
            },
            LucideIconKind.AudioWaveform => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "communication"],
                Tags = ["sound", "noise", "listen", "hearing", "hertz", "frequency", "wavelength", "vibrate", "sine", "synthesizer", "synthesiser", "levels", "track", "music", "playback", "radio", "broadcast", "airwaves", "voice", "vocals", "singer", "song"],
            },
            LucideIconKind.Award => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["account", "sports", "gaming"],
                Tags = ["achievement", "badge", "rosette", "prize", "winner"],
            },
            LucideIconKind.Axe => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "csandman", "jguddas", "karsa-mistmere"],
                Categories = ["tools", "gaming"],
                Tags = ["hatchet", "weapon", "chop", "sharp", "equipment", "fireman", "firefighter", "brigade", "lumberjack", "woodcutter", "logger", "forestry"],
            },
            LucideIconKind.Axis3d => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "jguddas"],
                Categories = ["design"],
                Tags = ["gizmo", "coordinates"],
            },
            LucideIconKind.Baby => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["accessibility", "people"],
                Tags = ["child", "childproof", "children"],
            },
            LucideIconKind.Backpack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["gaming", "photography", "travel"],
                Tags = ["bag", "hiking", "travel", "camping", "school", "childhood"],
            },
            LucideIconKind.Badge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["account", "social", "shapes"],
                Tags = ["check", "verified", "unverified"],
            },
            LucideIconKind.BadgeAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["account", "social"],
                Tags = ["check", "verified", "unverified", "security", "safety", "issue"],
            },
            LucideIconKind.BadgeCent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "cents", "dollar", "usd", "$", "¢"],
            },
            LucideIconKind.BadgeCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["social"],
                Tags = ["verified", "check"],
            },
            LucideIconKind.BadgeDollarSign => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "usd", "$"],
            },
            LucideIconKind.BadgeEuro => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "€"],
            },
            LucideIconKind.BadgeIndianRupee => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "inr", "₹"],
            },
            LucideIconKind.BadgeInfo => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["account", "accessibility", "social"],
                Tags = ["verified", "unverified", "help"],
            },
            LucideIconKind.BadgeJapaneseYen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "jpy", "¥"],
            },
            LucideIconKind.BadgeMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["social"],
                Tags = ["verified", "unverified", "delete", "remove", "erase"],
            },
            LucideIconKind.BadgePercent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["social", "finance", "shopping", "math"],
                Tags = ["verified", "unverified", "sale", "discount", "offer", "marketing", "sticker", "price tag"],
            },
            LucideIconKind.BadgePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["social"],
                Tags = ["verified", "unverified", "add", "create", "new"],
            },
            LucideIconKind.BadgePoundSterling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "british", "gbp", "£"],
            },
            LucideIconKind.BadgeQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["accessibility", "social", "shapes"],
                Tags = ["verified", "unverified", "help"],
            },
            LucideIconKind.BadgeRussianRuble => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "rub", "₽"],
            },
            LucideIconKind.BadgeSwissFranc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "chf", "₣"],
            },
            LucideIconKind.BadgeTurkishLira => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jamiemlaw"],
                Categories = ["shopping", "finance"],
                Tags = ["discount", "offer", "sale", "voucher", "tag", "monetization", "marketing", "finance", "financial", "exchange", "transaction", "payment", "try", "₺"],
            },
            LucideIconKind.BadgeX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["social"],
                Tags = ["verified", "unverified", "lost", "delete", "remove"],
            },
            LucideIconKind.BaggageClaim => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["transportation", "travel"],
                Tags = ["baggage", "luggage", "travel", "cart", "trolley", "suitcase"],
            },
            LucideIconKind.Ban => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["account"],
                Tags = ["cancel", "no", "stop", "forbidden", "prohibited", "error", "incorrect", "mistake", "wrong", "failure", "circle", "slash", "null", "void"],
            },
            LucideIconKind.Banana => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["fruit", "food"],
            },
            LucideIconKind.Bandage => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jamiemlaw"],
                Categories = ["medical"],
                Tags = ["plaster", "band-aid", "first aid", "medical", "health", "wound", "injury", "care", "treatment", "healing", "protection", "emergency", "aid", "safety", "patch"],
            },
            LucideIconKind.Banknote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.BanknoteArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "joffx", "ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["bill", "currency", "money", "payment", "funds", "transaction", "cash", "finance", "withdraw", "expense", "out", "payout", "refund", "debit", "spending", "decrease"],
            },
            LucideIconKind.BanknoteArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "joffx", "ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["bill", "currency", "money", "payment", "funds", "transaction", "cash", "finance", "deposit", "earnings", "income", "in", "credit", "prepaid", "growth", "increase"],
            },
            LucideIconKind.BanknoteX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "joffx", "ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["bill", "currency", "money", "payment", "funds", "transaction", "cash", "finance", "error", "failed", "rejected", "canceled", "declined", "lost", "delete", "remove"],
            },
            LucideIconKind.Barcode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping"],
                Tags = ["scan", "checkout", "till", "cart", "transaction", "purchase", "buy", "product", "packaging", "retail", "consumer"],
            },
            LucideIconKind.Barrel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jamiemlaw"],
                Categories = ["food-beverage", "navigation"],
                Tags = ["keg", "drum", "tank", "wine", "beer", "oak", "wood", "firkin", "hogshead", "kilderkin", "barrique", "solera", "aging", "whiskey", "brewery", "distillery", "winery", "vineyard"],
            },
            LucideIconKind.Baseline => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["text", "format", "color"],
            },
            LucideIconKind.Bath => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["travel"],
                Tags = ["amenities", "services", "bathroom", "shower"],
            },
            LucideIconKind.Battery => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "johnletey", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.BatteryCharging => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "johnletey", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.BatteryFull => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "johnletey", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.BatteryLow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "karsa-mistmere", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.BatteryMedium => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "karsa-mistmere", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.BatteryPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "johnletey", "Footagesus"],
                Categories = ["devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge", "plus", "economy", "health", "add", "new", "maximum", "upgrade", "extra", "+"],
            },
            LucideIconKind.BatteryWarning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Kaladii", "ericfennis", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["power", "electricity", "energy", "accumulator", "charge", "exclamation mark"],
            },
            LucideIconKind.Beaker => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis"],
                Categories = ["science", "gaming"],
                Tags = ["cup", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.Bean => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["legume", "soy", "food", "seed"],
            },
            LucideIconKind.BeanOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["soy free", "legume", "soy", "food", "seed", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.Bed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["home"],
                Tags = ["sleep", "hotel", "furniture"],
            },
            LucideIconKind.BedDouble => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["home"],
                Tags = ["sleep", "hotel", "furniture"],
            },
            LucideIconKind.BedSingle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["home"],
                Tags = ["sleep", "hotel", "furniture"],
            },
            LucideIconKind.Beef => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie", "ericfennis", "karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["food", "dish", "restaurant", "course", "meal", "meat", "bbq", "steak"],
            },
            LucideIconKind.Beer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["alcohol", "bar", "beverage", "brewery", "drink"],
            },
            LucideIconKind.BeerOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["alcohol", "bar", "beverage", "brewery", "drink"],
            },
            LucideIconKind.Bell => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley"],
                Categories = ["account", "notifications"],
                Tags = ["alarm", "notification", "sound", "reminder"],
            },
            LucideIconKind.BellDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account", "notifications"],
                Tags = ["alarm", "notification", "sound", "reminder", "unread"],
            },
            LucideIconKind.BellElectric => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["devices", "notifications", "home"],
                Tags = ["fire alarm", "flames", "smoke", "firefighter", "fireman", "department", "brigade", "station", "emergency", "alert", "safety", "school bell", "period break", "recess", "doorbell", "entrance", "entry", "ring", "reception"],
            },
            LucideIconKind.BellMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "danielbayley"],
                Categories = ["notifications"],
                Tags = ["alarm", "notification", "silent", "reminder", "delete", "remove", "erase"],
            },
            LucideIconKind.BellOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "danielbayley"],
                Categories = ["notifications"],
                Tags = ["alarm", "notification", "silent", "reminder"],
            },
            LucideIconKind.BellPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "danielbayley"],
                Categories = ["notifications"],
                Tags = ["notification", "silent", "reminder", "add", "create", "new"],
            },
            LucideIconKind.BellRing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["notifications"],
                Tags = ["alarm", "notification", "sound", "reminder"],
            },
            LucideIconKind.BetweenHorizontalEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "tools"],
                Tags = ["insert", "add", "left", "slot", "squeeze", "space", "vertical", "grid", "table", "rows", "cells", "excel", "spreadsheet", "accountancy", "data", "enter", "entry", "entries", "blocks", "rectangles", "chevron"],
            },
            LucideIconKind.BetweenHorizontalStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "tools"],
                Tags = ["insert", "add", "right", "slot", "squeeze", "space", "vertical", "grid", "table", "rows", "cells", "excel", "spreadsheet", "accountancy", "data", "enter", "entry", "entries", "blocks", "rectangles", "chevron"],
            },
            LucideIconKind.BetweenVerticalEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "tools"],
                Tags = ["insert", "add", "top", "slot", "squeeze", "space", "vertical", "grid", "table", "columns", "cells", "data", "enter", "entry", "entries", "blocks", "rectangles", "chevron"],
            },
            LucideIconKind.BetweenVerticalStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "tools"],
                Tags = ["insert", "add", "bottom", "slot", "squeeze", "space", "vertical", "grid", "table", "columns", "cells", "data", "enter", "entry", "entries", "blocks", "rectangles", "chevron"],
            },
            LucideIconKind.BicepsFlexed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["emoji"],
                Tags = ["arm", "muscle", "strong", "working out", "athletic", "toned", "muscular", "forelimb", "curled"],
            },
            LucideIconKind.Bike => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis", "Andreto", "csandman", "jguddas", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["bicycle", "transport", "trip"],
            },
            LucideIconKind.Binary => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "karsa-mistmere", "ericfennis"],
                Categories = ["text", "development"],
                Tags = ["code", "digits", "computer", "zero", "one", "boolean"],
            },
            LucideIconKind.Binoculars => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["navigation", "nature", "photography", "science", "travel", "development"],
                Tags = ["field glasses", "lorgnette", "pince-nez", "observation", "sightseeing", "nature", "wildlife", "birdwatching", "scouting", "surveillance", "search", "discovery", "monitoring", "lookout", "viewpoint", "travel", "tourism", "research"],
            },
            LucideIconKind.Biohazard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "ericfennis"],
                Categories = ["science"],
                Tags = ["fallout", "waste", "biology", "chemistry", "chemical", "element"],
            },
            LucideIconKind.Bird => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["animals"],
                Tags = ["peace", "freedom", "wing", "avian", "tweet"],
            },
            LucideIconKind.Birdhouse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["hieu-onefold", "karsa-mistmere"],
                Categories = ["nature", "animals", "navigation", "home"],
                Tags = ["birdhouse", "bird", "garden", "home", "house", "woodwork"],
            },
            LucideIconKind.Bitcoin => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["brands", "development", "finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Blend => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["design", "photography", "tools", "development"],
                Tags = ["mode", "overlay", "multiply", "screen", "opacity", "transparency", "alpha", "filters", "lenses", "mixed", "shades", "tints", "hues", "saturation", "brightness", "overlap", "colors", "colours"],
            },
            LucideIconKind.Blinds => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["home"],
                Tags = ["shades", "screen", "curtain", "shutter", "roller blind", "window", "lighting", "household", "home"],
            },
            LucideIconKind.Blocks => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development", "layout", "shapes"],
                Tags = ["addon", "plugin", "integration", "extension", "package", "build", "stack", "toys", "kids", "children", "learning", "squares", "corner"],
            },
            LucideIconKind.Bluetooth => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman"],
                Categories = ["connectivity", "devices"],
                Tags = ["wireless"],
            },
            LucideIconKind.BluetoothConnected => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["connectivity", "devices"],
                Tags = ["paired"],
            },
            LucideIconKind.BluetoothOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["connectivity", "devices"],
                Tags = ["lost"],
            },
            LucideIconKind.BluetoothSearching => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["connectivity", "devices"],
                Tags = ["pairing"],
            },
            LucideIconKind.Bold => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "strong", "format"],
            },
            LucideIconKind.Bolt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["tools", "home"],
                Tags = ["nut", "screw", "settings", "preferences", "configuration", "controls", "edit", "diy", "fixed", "build", "construction", "parts"],
            },
            LucideIconKind.Bomb => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["security", "tools"],
                Tags = ["fatal", "error", "crash", "blockbuster", "mine", "explosion", "explode", "explosive"],
            },
            LucideIconKind.Bone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["animals", "medical", "gaming"],
                Tags = ["health", "skeleton", "skull", "death", "pets", "dog"],
            },
            LucideIconKind.Book => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["text", "development", "gaming"],
                Tags = ["reading", "paperback", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation"],
            },
            LucideIconKind.BookA => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "gaming"],
                Tags = ["dictionary", "define", "definition", "thesaurus", "encyclopedia", "encyclopaedia", "reading", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "language", "translate", "alphabetical", "a-z", "ordered"],
            },
            LucideIconKind.BookAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "lscheibel", "domasmark"],
                Categories = ["text", "development", "gaming"],
                Tags = ["reading", "paperback", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation", "warning", "alert", "danger", "exclamation mark"],
            },
            LucideIconKind.BookAudio => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "text"],
                Tags = ["audiobook", "reading", "listening", "sound", "story", "fiction", "novel", "information", "knowledge", "education", "student", "study", "learning", "research"],
            },
            LucideIconKind.BookCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "development", "gaming"],
                Tags = ["read", "booklet", "magazine", "leaflet", "pamphlet", "library", "written", "authored", "published", "informed", "knowledgeable", "educated", "schooled", "homework", "examined", "tested", "marked", "passed", "graduated", "studied", "learned", "lesson", "researched", "documented", "revealed", "blank", "plain language", "true", "truth", "verified", "corrected", "task", "todo", "done", "completed", "finished", "ticked"],
            },
            LucideIconKind.BookCopy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["development", "text", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "clone", "fork", "duplicate", "multiple", "books", "library", "copies", "copied", "plagiarism", "plagiarised", "plagiarized", "reading list", "information", "informed", "knowledge", "knowledgeable", "knowledgable", "education", "high school", "university", "college", "academy", "student", "study", "learning", "research", "smart", "intelligent", "intellectual"],
            },
            LucideIconKind.BookDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development"],
                Tags = ["code", "coding", "version control", "git", "repository", "template", "draft", "script", "screenplay", "writing", "writer", "author", "unwritten", "unpublished", "untold"],
            },
            LucideIconKind.BookDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development"],
                Tags = ["code", "coding", "version control", "git", "repository", "pull"],
            },
            LucideIconKind.BookHeadphones => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "text"],
                Tags = ["audiobook", "reading", "listening", "sound", "story", "fiction", "novel", "information", "knowledge", "education", "student", "study", "learning", "research"],
            },
            LucideIconKind.BookHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social", "text", "gaming"],
                Tags = ["diary", "romance", "novel", "journal", "entry", "entries", "personal", "private", "secret", "crush", "like", "love", "emotion", "feminine", "girls", "teens", "teenager", "therapy", "theraputic", "therapist", "planner", "organizer", "organiser", "notes", "notepad", "stationery", "sketchbook", "writing", "written", "reading", "favorite", "favourite", "high school"],
            },
            LucideIconKind.BookImage => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["photography", "text", "multimedia", "files", "social", "shopping", "travel"],
                Tags = ["images", "pictures", "photos", "album", "collection", "event", "magazine", "catalog", "catalogue", "brochure", "browse", "gallery"],
            },
            LucideIconKind.BookKey => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["development", "security", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "private", "public", "secret", "unlocked", "hidden", "revealed", "knowledge", "learning"],
            },
            LucideIconKind.BookLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "security", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "private", "secret", "hidden", "knowledge"],
            },
            LucideIconKind.BookMarked => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "development", "gaming"],
                Tags = ["dictionary", "reading", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation", "saved", "later", "future", "reference", "index", "code", "coding", "version control", "git", "repository"],
            },
            LucideIconKind.BookMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "text", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "remove", "delete", "censor", "cancel", "forbid", "prohibit", "ban", "uneducated", "re-educate", "unlearn", "downgrade"],
            },
            LucideIconKind.BookOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["text", "development", "gaming"],
                Tags = ["reading", "pages", "booklet", "magazine", "leaflet", "pamphlet", "library", "writing", "written", "writer", "author", "story", "script", "screenplay", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation", "revealed", "blank", "plain"],
            },
            LucideIconKind.BookOpenCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["schmidt-oliver", "karsa-mistmere", "ericfennis"],
                Categories = ["text", "development", "gaming"],
                Tags = ["read", "pages", "booklet", "magazine", "leaflet", "pamphlet", "library", "written", "authored", "published", "informed", "knowledgeable", "educated", "schooled", "homework", "examined", "tested", "marked", "passed", "graduated", "studied", "learned", "lesson", "researched", "documented", "revealed", "blank", "plain language", "true", "truth", "verified", "corrected", "task", "todo", "done", "completed", "finished", "ticked"],
            },
            LucideIconKind.BookOpenText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "development"],
                Tags = ["reading", "pages", "booklet", "magazine", "leaflet", "pamphlet", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation", "revealed"],
            },
            LucideIconKind.BookPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "text", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "remove", "delete", "read", "write", "author", "publish", "inform", "graduate", "re-educate", "study", "learn", "research", "knowledge", "improve", "upgrade", "level up"],
            },
            LucideIconKind.BookText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "gaming"],
                Tags = ["reading", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "documentation"],
            },
            LucideIconKind.BookType => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "design", "gaming"],
                Tags = ["thesaurus", "synonym", "reading", "booklet", "magazine", "leaflet", "pamphlet", "tome", "library", "writing", "written", "writer", "author", "story", "script", "fiction", "novel", "information", "knowledge", "education", "high school", "university", "college", "academy", "student", "study", "learning", "homework", "research", "language", "translate", "typography", "fonts", "collection"],
            },
            LucideIconKind.BookUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development"],
                Tags = ["code", "coding", "version control", "git", "repository", "push"],
            },
            LucideIconKind.BookUp2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development"],
                Tags = ["code", "coding", "version control", "git", "repository", "push", "force"],
            },
            LucideIconKind.BookUser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account", "connectivity", "communication", "social"],
                Tags = ["person", "people", "family", "friends", "acquaintances", "contacts", "details", "addresses", "phone numbers", "directory", "listing", "networking"],
            },
            LucideIconKind.BookX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "gaming"],
                Tags = ["code", "coding", "version control", "git", "repository", "remove", "delete", "reading", "misinformation", "disinformation", "misinformed", "charlatan", "sophistry", "false", "lies", "untruth", "propaganda", "censored", "cancelled", "forbidden", "prohibited", "banned", "uneducated", "re-education", "unlearn"],
            },
            LucideIconKind.Bookmark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "siarie", "ericfennis"],
                Categories = ["account"],
                Tags = ["read", "clip", "marker", "tag"],
            },
            LucideIconKind.BookmarkCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account"],
                Tags = ["read", "finished", "complete", "clip", "marker", "tag", "task", "todo"],
            },
            LucideIconKind.BookmarkMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["siarie", "ericfennis"],
                Categories = ["account"],
                Tags = ["delete", "remove"],
            },
            LucideIconKind.BookmarkPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["siarie", "ericfennis"],
                Categories = ["account"],
                Tags = ["add"],
            },
            LucideIconKind.BookmarkX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account"],
                Tags = ["read", "clip", "marker", "tag", "cancel", "close", "delete", "remove", "clear"],
            },
            LucideIconKind.BoomBox => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "multimedia", "social"],
                Tags = ["radio", "speakers", "audio", "music", "sound", "broadcast", "live", "frequency"],
            },
            LucideIconKind.Bot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["development", "social"],
                Tags = ["robot", "ai", "chat", "assistant"],
            },
            LucideIconKind.BotMessageSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["development", "social"],
                Tags = ["robot", "ai", "chat", "assistant"],
            },
            LucideIconKind.BotOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["taichimaeda", "ericfennis"],
                Categories = ["development", "social"],
                Tags = ["robot", "ai", "chat", "assistant"],
            },
            LucideIconKind.BottleWine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["food-beverage"],
                Tags = ["alcohol", "drink", "glass", "goblet", "chalice", "vineyard", "winery", "red", "white", "rose", "dry", "sparkling", "bar", "party", "nightclub", "nightlife", "sommelier", "restaurant", "dinner", "meal"],
            },
            LucideIconKind.BowArrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["gaming", "tools"],
                Tags = ["archer", "archery", "game", "war", "weapon"],
            },
            LucideIconKind.Box => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["shapes", "gaming", "development", "math"],
                Tags = ["cube", "package", "container", "storage", "geometry", "3d", "isometric"],
            },
            LucideIconKind.Boxes => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["shapes", "gaming", "development"],
                Tags = ["cubes", "packages", "parts", "group", "units", "collection", "cluster", "geometry"],
            },
            LucideIconKind.Braces => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["development", "files"],
                Tags = ["json", "code", "token", "curly brackets", "data", "{", "}"],
            },
            LucideIconKind.Brackets => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["development", "files"],
                Tags = ["code", "token", "array", "list", "square", "[", "]"],
            },
            LucideIconKind.Brain => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "it-is-not", "jamiemlaw"],
                Categories = ["medical", "science"],
                Tags = ["medical", "mind", "mental", "intellect", "cerebral", "consciousness", "genius", "artificial intelligence", "ai", "think", "thought", "insight", "intelligent", "smart"],
            },
            LucideIconKind.BrainCircuit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "it-is-not", "ericfennis"],
                Categories = ["science", "development"],
                Tags = ["mind", "intellect", "artificial intelligence", "ai", "deep learning", "machine learning", "computing"],
            },
            LucideIconKind.BrainCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "it-is-not", "UsamaKhan"],
                Categories = ["science", "development"],
                Tags = ["mind", "intellect", "artificial intelligence", "ai", "deep learning", "machine learning", "computing"],
            },
            LucideIconKind.BrickWall => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["buildings", "home"],
                Tags = ["bricks", "mortar", "cement", "materials", "construction", "builder", "labourer", "quantity surveyor", "blocks", "stone"],
            },
            LucideIconKind.BrickWallFire => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["security", "home", "connectivity"],
                Tags = ["firewall", "security", "bricks", "mortar", "cement", "materials", "construction", "builder", "labourer", "quantity surveyor", "blocks", "stone", "campfire", "camping", "wilderness", "outdoors", "lit", "warmth", "wood", "twigs", "sticks"],
            },
            LucideIconKind.BrickWallShield => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["security", "home", "connectivity"],
                Tags = ["firewall", "security", "bricks", "mortar", "cement", "materials", "construction", "builder", "labourer", "quantity surveyor", "blocks", "stone", "cybersecurity", "secure", "safety", "protection", "guardian", "armored", "armoured", "defense", "defence", "defender", "block", "threat", "prevention", "antivirus", "vigilance", "vigilant", "detection", "scan", "find", "strength", "strong", "tough", "invincible", "invincibility", "invulnerable", "undamaged", "audit", "admin", "verification", "crest", "bravery", "knight", "foot soldier", "infantry", "trooper", "pawn", "battle", "war", "military", "army", "cadet", "scout"],
            },
            LucideIconKind.Briefcase => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["transportation"],
                Tags = ["work", "bag", "baggage", "folder"],
            },
            LucideIconKind.BriefcaseBusiness => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["work", "bag", "baggage", "folder", "portfolio"],
            },
            LucideIconKind.BriefcaseConveyorBelt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["travel", "transportation"],
                Tags = ["baggage", "luggage", "travel", "suitcase", "conveyor", "carousel"],
            },
            LucideIconKind.BriefcaseMedical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["medical", "transportation"],
                Tags = ["doctor", "medicine", "first aid"],
            },
            LucideIconKind.BringToFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["james-yeoman", "jguddas"],
                Categories = ["design", "layout"],
                Tags = ["bring", "send", "move", "over", "forward", "front", "overlap", "layer", "order"],
            },
            LucideIconKind.Brush => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "chessurisme", "jguddas", "karsa-mistmere"],
                Categories = ["text", "design", "tools"],
                Tags = ["clean", "sweep", "refactor", "remove", "draw", "paint", "color", "artist"],
            },
            LucideIconKind.BrushCleaning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home", "tools", "design"],
                Tags = ["cleaning", "utensil", "housekeeping", "tool", "sweeping", "scrubbing", "hygiene", "maintenance", "household", "cleaner", "chores", "equipment", "sanitation", "bristles", "handle", "home care", "sanitize", "purify", "wash", "disinfect", "sterilize", "scrub", "polish", "decontaminate", "wipe", "spotless", "remove", "empty", "erase", "purge", "eliminate"],
            },
            LucideIconKind.Bubbles => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["vqh2602", "jguddas"],
                Categories = ["weather"],
                Tags = ["water", "cleaning", "soap", "bath", "hygiene", "freshness", "wash", "foam", "cleanliness", "shampoo", "purity", "splash", "lightness", "airy", "relaxation", "spa", "bubbly", "fluid", "floating", "drop"],
            },
            LucideIconKind.Bug => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jamiemlaw"],
                Categories = ["development", "animals"],
                Tags = ["issue", "error", "defect", "testing", "troubleshoot", "problem", "report", "debug", "code", "insect", "beetle"],
            },
            LucideIconKind.BugOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jamiemlaw"],
                Categories = ["development", "animals"],
                Tags = ["issue", "fixed", "resolved", "testing", "debug", "code", "insect", "kill", "exterminate", "pest control"],
            },
            LucideIconKind.BugPlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere", "jamiemlaw"],
                Categories = ["development", "animals"],
                Tags = ["issue", "testing", "debug", "reproduce", "code", "insect"],
            },
            LucideIconKind.Building => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["account", "buildings"],
                Tags = ["organisation", "organization"],
            },
            LucideIconKind.Building2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["maxim-s-barabash", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["account", "buildings"],
                Tags = ["business", "company", "enterprise", "skyscraper", "organisation", "organization", "city"],
            },
            LucideIconKind.Bus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis", "Andreto", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["bus", "vehicle", "transport", "trip"],
            },
            LucideIconKind.BusFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["coach", "vehicle", "trip", "road"],
            },
            LucideIconKind.Cable => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["connectivity", "devices", "multimedia"],
                Tags = ["cord", "wire", "connector", "connection", "link", "signal", "console", "computer", "equipment", "electricity", "energy", "electronics", "recharging", "charger", "power", "supply", "disconnected", "unplugged", "plugs", "interface", "input", "output", "audio video", "av", "rca", "scart", "tv", "television", "optical"],
            },
            LucideIconKind.CableCar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "travel"],
                Tags = ["ski lift", "winter holiday", "alpine", "resort", "mountains"],
            },
            LucideIconKind.Cake => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["food-beverage", "social", "account"],
                Tags = ["birthday", "birthdate", "celebration", "party", "surprise", "gateaux", "dessert", "fondant", "icing sugar", "sweet", "baking"],
            },
            LucideIconKind.CakeSlice => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["food-beverage", "social"],
                Tags = ["birthday", "birthdate", "celebration", "party", "surprise", "gateaux", "dessert", "candles", "wish", "fondant", "icing sugar", "sweet", "baking"],
            },
            LucideIconKind.Calculator => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["math", "devices"],
                Tags = ["count", "calculating machine"],
            },
            LucideIconKind.Calendar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event", "birthday", "birthdate"],
            },
            LucideIconKind.Calendar1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "peteruithoven"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event", "single", "singular", "once", "1", "first"],
            },
            LucideIconKind.CalendarArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event", "sort", "order", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.CalendarArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event", "sort", "order", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.CalendarCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "confirm", "subscribe", "schedule", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CalendarCheck2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "confirm", "subscribe", "schedule", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CalendarClock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "clock", "hour"],
            },
            LucideIconKind.CalendarCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "AlexandrePhilibert", "UsamaKhan", "jguddas"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "events", "settings", "gear", "cog"],
            },
            LucideIconKind.CalendarDays => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event"],
            },
            LucideIconKind.CalendarFold => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["time", "files"],
                Tags = ["date", "month", "year", "event", "birthday", "birthdate", "ics"],
            },
            LucideIconKind.CalendarHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["time"],
                Tags = ["date", "month", "year", "event", "heart", "favourite", "subscribe", "valentines day"],
            },
            LucideIconKind.CalendarMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "delete", "remove"],
            },
            LucideIconKind.CalendarMinus2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "delete", "remove"],
            },
            LucideIconKind.CalendarOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "delete", "remove"],
            },
            LucideIconKind.CalendarPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "add", "subscribe", "create", "new"],
            },
            LucideIconKind.CalendarPlus2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "add", "subscribe", "create", "new"],
            },
            LucideIconKind.CalendarRange => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "range", "period"],
            },
            LucideIconKind.CalendarSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "events", "search", "lens"],
            },
            LucideIconKind.CalendarSync => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere", "chessurisme"],
                Categories = ["arrows", "time"],
                Tags = ["repeat", "refresh", "reconnect", "transfer", "backup", "date", "month", "year", "event", "subscribe", "recurring", "schedule", "reminder", "automatic", "auto"],
            },
            LucideIconKind.CalendarX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "remove", "busy"],
            },
            LucideIconKind.CalendarX2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["time"],
                Tags = ["date", "day", "month", "year", "event", "remove"],
            },
            LucideIconKind.Camera => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "lscheibel", "ericfennis", "karsa-mistmere"],
                Categories = ["photography", "devices", "communication"],
                Tags = ["photography", "lens", "focus", "capture", "shot", "visual", "image", "device", "equipment", "photo", "webcam", "video"],
            },
            LucideIconKind.CameraOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "lscheibel", "Andreto", "ericfennis", "karsa-mistmere"],
                Categories = ["photography", "devices", "communication"],
                Tags = ["photo", "webcam", "video"],
            },
            LucideIconKind.Candy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["sugar", "food", "sweet"],
            },
            LucideIconKind.CandyCane => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["sugar", "food", "sweet", "christmas", "xmas"],
            },
            LucideIconKind.CandyOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["sugar free", "food", "sweet", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.Cannabis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "karsa-mistmere"],
                Categories = ["nature"],
                Tags = ["cannabis", "weed", "leaf"],
            },
            LucideIconKind.Captions => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["DefaultLP"],
                Categories = ["multimedia"],
                Tags = ["closed captions", "subtitles", "subhead", "transcription", "transcribe", "dialogue", "accessibility"],
            },
            LucideIconKind.CaptionsOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["DefaultLP"],
                Categories = ["multimedia"],
                Tags = ["closed captions", "subtitles", "subhead", "transcription", "transcribe", "dialogue", "accessibility"],
            },
            LucideIconKind.Car => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis", "Andreto"],
                Categories = ["transportation"],
                Tags = ["vehicle", "drive", "trip", "journey"],
            },
            LucideIconKind.CarFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["vehicle", "drive", "trip", "journey"],
            },
            LucideIconKind.CarTaxiFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["cab", "vehicle", "drive", "trip", "journey"],
            },
            LucideIconKind.Caravan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["transportation", "travel", "nature"],
                Tags = ["trailer", "tow", "camping", "campsite", "mobile home", "holiday", "nomadic", "wilderness", "outdoors"],
            },
            LucideIconKind.CardSim => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["connectivity", "communication", "multimedia", "devices"],
                Tags = ["cellphone", "smartphone", "mobile", "network", "cellular", "service", "provider", "signal", "coverage", "disk", "data", "format", "storage", "flash", "digital", "contacts", "phone book", "contractual", "circuit board", "chip"],
            },
            LucideIconKind.Carrot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["vegetable", "food", "eat"],
            },
            LucideIconKind.CaseLower => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "vichotech", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["text", "letters", "characters", "font", "typography"],
            },
            LucideIconKind.CaseSensitive => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "vichotech", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "letters", "characters", "font", "typography"],
            },
            LucideIconKind.CaseUpper => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "vichotech", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["text", "letters", "characters", "font", "typography"],
            },
            LucideIconKind.CassetteTape => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["connectivity", "devices", "multimedia", "communication", "files"],
                Tags = ["audio", "music", "recording", "play"],
            },
            LucideIconKind.Cast => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["devices", "connectivity"],
                Tags = ["chromecast", "airplay", "screen"],
            },
            LucideIconKind.Castle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "gaming"],
                Tags = ["fortress", "stronghold", "palace", "chateau", "building"],
            },
            LucideIconKind.Cat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie"],
                Categories = ["animals"],
                Tags = ["animal", "pet", "kitten", "feline"],
            },
            LucideIconKind.Cctv => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["security", "devices", "communication", "connectivity", "photography"],
                Tags = ["camera", "surveillance", "recording", "film", "videotape", "crime", "watching"],
            },
            LucideIconKind.ChartArea => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["nstokoe"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "area"],
            },
            LucideIconKind.ChartBar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartBarBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartBarDecreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending down"],
            },
            LucideIconKind.ChartBarIncreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending up"],
            },
            LucideIconKind.ChartBarStacked => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "multivariate", "categorical", "comparison"],
            },
            LucideIconKind.ChartCandlestick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["charts", "finance"],
                Tags = ["trading", "trader", "financial", "markets", "portfolio", "assets", "prices", "value", "valuation", "commodities", "currencies", "currency", "stocks", "exchange", "hedge fund", "statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartColumn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartColumnBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartColumnDecreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending down"],
            },
            LucideIconKind.ChartColumnIncreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending up"],
            },
            LucideIconKind.ChartColumnStacked => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "multivariate", "categorical", "comparison"],
            },
            LucideIconKind.ChartGantt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["charts"],
                Tags = ["diagram", "graph", "timeline", "planning"],
            },
            LucideIconKind.ChartLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartNetwork => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "topology", "cluster", "web", "nodes", "connections", "edges"],
            },
            LucideIconKind.ChartNoAxesColumn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartNoAxesColumnDecreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending down"],
            },
            LucideIconKind.ChartNoAxesColumnIncreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending up"],
            },
            LucideIconKind.ChartNoAxesCombined => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "trending up"],
            },
            LucideIconKind.ChartNoAxesGantt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["charts", "time", "development", "design"],
                Tags = ["projects", "manage", "overview", "roadmap", "plan", "intentions", "timeline", "deadline", "date", "event", "range", "period", "productivity", "work", "agile", "code", "coding"],
            },
            LucideIconKind.ChartPie => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["charts", "files"],
                Tags = ["statistics", "analytics", "diagram", "presentation"],
            },
            LucideIconKind.ChartScatter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph"],
            },
            LucideIconKind.ChartSpline => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["charts"],
                Tags = ["statistics", "analytics", "diagram", "graph", "curve", "continuous", "smooth", "polynomial", "quadratic", "function", "interpolation"],
            },
            LucideIconKind.Check => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CheckCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["notifications"],
                Tags = ["done", "received", "double", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CheckLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "oosawy"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.ChefHat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["cooking", "food", "kitchen", "restaurant"],
            },
            LucideIconKind.Cherry => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["fruit", "food"],
            },
            LucideIconKind.ChevronDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["backwards", "reverse", "slow", "dropdown"],
            },
            LucideIconKind.ChevronFirst => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["dperezcabrera", "ericfennis"],
                Categories = ["arrows", "multimedia"],
                Tags = ["previous", "music"],
            },
            LucideIconKind.ChevronLast => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["dperezcabrera", "ericfennis"],
                Categories = ["arrows", "multimedia"],
                Tags = ["skip", "next", "music"],
            },
            LucideIconKind.ChevronLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "previous", "less than", "fewer", "menu", "<"],
            },
            LucideIconKind.ChevronRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "math", "development"],
                Tags = ["forward", "next", "more than", "greater", "menu", "code", "coding", "command line", "terminal", "prompt", "shell", ">"],
            },
            LucideIconKind.ChevronUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "math", "gaming"],
                Tags = ["caret", "keyboard", "mac", "control", "ctrl", "superscript", "exponential", "power", "ahead", "fast", "^", "dropdown"],
            },
            LucideIconKind.ChevronsDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["backwards", "reverse", "slower"],
            },
            LucideIconKind.ChevronsDownUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["PeterlitsZo", "mittalyashu", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["collapse", "fold", "vertical"],
            },
            LucideIconKind.ChevronsLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["turn", "corner"],
            },
            LucideIconKind.ChevronsLeftRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["arrows"],
                Tags = ["expand", "horizontal", "unfold"],
            },
            LucideIconKind.ChevronsLeftRightEllipsis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["communication", "devices", "multimedia", "gaming"],
                Tags = ["internet", "network", "connection", "cable", "lan", "port", "router", "switch", "hub", "modem", "web", "online", "networking", "communication", "socket", "plug", "slot", "controller", "connector", "interface", "console", "signal", "data", "input", "output"],
            },
            LucideIconKind.ChevronsRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["turn", "corner"],
            },
            LucideIconKind.ChevronsRightLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["arrows"],
                Tags = ["collapse", "fold", "horizontal"],
            },
            LucideIconKind.ChevronsUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["forward", "ahead", "faster", "speed", "boost"],
            },
            LucideIconKind.ChevronsUpDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["expand", "unfold", "vertical"],
            },
            LucideIconKind.Chromium => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["brands"],
                Tags = ["browser", "logo"],
            },
            LucideIconKind.Church => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["buildings", "navigation"],
                Tags = ["temple", "building"],
            },
            LucideIconKind.Cigarette => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["travel", "transportation", "medical"],
                Tags = ["smoking"],
            },
            LucideIconKind.CigaretteOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["travel", "transportation", "medical"],
                Tags = ["smoking", "no-smoking"],
            },
            LucideIconKind.Circle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["shapes"],
                Tags = ["off", "zero", "record", "shape"],
            },
            LucideIconKind.CircleAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["notifications"],
                Tags = ["warning", "alert", "danger", "exclamation mark"],
            },
            LucideIconKind.CircleArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["backwards", "reverse", "direction", "south", "sign", "button"],
            },
            LucideIconKind.CircleArrowLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["previous", "back", "direction", "west", "sign", "turn", "button", "<-"],
            },
            LucideIconKind.CircleArrowOutDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "south-west", "diagonal"],
            },
            LucideIconKind.CircleArrowOutDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "south-east", "diagonal"],
            },
            LucideIconKind.CircleArrowOutUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "development"],
                Tags = ["outwards", "direction", "north-west", "diagonal", "keyboard", "button", "escape"],
            },
            LucideIconKind.CircleArrowOutUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "north-east", "diagonal"],
            },
            LucideIconKind.CircleArrowRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["next", "forward", "direction", "east", "sign", "turn", "button", "->"],
            },
            LucideIconKind.CircleArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["forward", "direction", "north", "sign", "button"],
            },
            LucideIconKind.CircleCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CircleCheckBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.CircleChevronDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "menu"],
            },
            LucideIconKind.CircleChevronLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "previous", "less than", "fewer", "menu", "<"],
            },
            LucideIconKind.CircleChevronRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "more than", "greater", "menu", ">"],
            },
            LucideIconKind.CircleChevronUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["caret", "ahead", "menu", "^"],
            },
            LucideIconKind.CircleDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development", "shapes"],
                Tags = ["pending", "dot", "progress", "issue", "draft", "code", "coding", "version control"],
            },
            LucideIconKind.CircleDivide => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis"],
                Categories = ["math"],
                Tags = ["calculate", "math", "÷", "/"],
            },
            LucideIconKind.CircleDollarSign => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["finance"],
                Tags = ["monetization", "marketing", "currency", "money", "payment"],
            },
            LucideIconKind.CircleDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["development", "shapes"],
                Tags = ["pending", "dot", "progress", "issue", "code", "coding", "version control", "choices", "multiple choice", "choose"],
            },
            LucideIconKind.CircleDotDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "shapes"],
                Tags = ["pending", "dot", "progress", "issue", "draft", "code", "coding", "version control"],
            },
            LucideIconKind.CircleEllipsis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["layout", "development"],
                Tags = ["ellipsis", "et cetera", "etc", "loader", "loading", "progress", "pending", "throbber", "menu", "options", "operator", "code", "spread", "rest", "more", "further", "extra", "overflow", "dots", "…", "..."],
            },
            LucideIconKind.CircleEqual => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math"],
                Tags = ["calculate", "shape", "="],
            },
            LucideIconKind.CircleFadingArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jordan808", "jguddas", "colebemis", "ericfennis", "mosch"],
                Categories = ["arrows", "development"],
                Tags = ["north", "up", "upgrade", "improve", "circle", "button"],
            },
            LucideIconKind.CircleFadingPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jordan808", "jguddas"],
                Categories = ["communication", "social"],
                Tags = ["stories", "social media", "instagram", "facebook", "meta", "snapchat", "sharing", "content"],
            },
            LucideIconKind.CircleGauge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "sports", "science"],
                Tags = ["dashboard", "dial", "meter", "speed", "pressure", "measure", "level"],
            },
            LucideIconKind.CircleMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math"],
                Tags = ["subtract", "remove", "decrease", "reduce", "calculate", "line", "operator", "code", "coding", "minimum", "downgrade", "-"],
            },
            LucideIconKind.CircleOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes"],
                Tags = ["diameter", "zero", "Ø", "nothing", "null", "void", "cancel", "ban", "no", "stop", "forbidden", "prohibited", "error", "incorrect", "mistake", "wrong", "failure"],
            },
            LucideIconKind.CircleParking => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["transportation", "navigation"],
                Tags = ["parking lot", "car park"],
            },
            LucideIconKind.CircleParkingOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["transportation", "navigation"],
                Tags = ["parking lot", "car park", "no parking"],
            },
            LucideIconKind.CirclePause => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["multimedia"],
                Tags = ["music", "audio", "stop"],
            },
            LucideIconKind.CirclePercent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["social", "finance", "shopping", "math"],
                Tags = ["verified", "unverified", "sale", "discount", "offer", "marketing", "sticker", "price tag"],
            },
            LucideIconKind.CirclePlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["music", "start", "run"],
            },
            LucideIconKind.CirclePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "development", "cursors", "gaming"],
                Tags = ["add", "new", "increase", "increment", "positive", "calculate", "crosshair", "aim", "target", "scope", "sight", "reticule", "maximum", "upgrade", "extra", "operator", "join", "concatenate", "code", "coding", "+"],
            },
            LucideIconKind.CirclePoundSterling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley", "LieOnLion"],
                Categories = ["finance"],
                Tags = ["monetization", "coin", "penny", "marketing", "currency", "money", "payment", "british", "gbp", "£"],
            },
            LucideIconKind.CirclePower => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["connectivity"],
                Tags = ["on", "off", "device", "switch", "toggle", "binary", "boolean", "reboot", "restart", "button", "keyboard", "troubleshoot"],
            },
            LucideIconKind.CircleQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danbovey", "colebemis", "csandman", "ericfennis", "danielbayley"],
                Categories = ["accessibility", "text", "notifications"],
                Tags = ["question mark"],
            },
            LucideIconKind.CircleSlash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "math"],
                Tags = ["diameter", "zero", "Ø", "nothing", "null", "void", "cancel", "ban", "no", "stop", "forbidden", "prohibited", "error", "incorrect", "mistake", "wrong", "failure", "divide", "division", "or", "/"],
            },
            LucideIconKind.CircleSlash2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "math", "development"],
                Tags = ["diameter", "zero", "ø", "nothing", "null", "void", "ban", "math", "divide", "division", "half", "split", "/", "average", "avg", "mean", "median", "normal"],
            },
            LucideIconKind.CircleSmall => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["shapes", "medical"],
                Tags = ["shape", "bullet", "gender", "genderless"],
            },
            LucideIconKind.CircleStar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["sports", "gaming"],
                Tags = ["badge", "medal", "honour", "decoration", "order", "pin", "laurel", "trophy", "medallion", "insignia", "bronze", "silver", "gold"],
            },
            LucideIconKind.CircleStop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["multimedia"],
                Tags = ["media", "music"],
            },
            LucideIconKind.CircleUser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.CircleUserRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.CircleX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "development"],
                Tags = ["cancel", "close", "delete", "remove", "times", "clear", "error", "incorrect", "wrong", "mistake", "failure", "linter", "multiply", "multiplication"],
            },
            LucideIconKind.CircuitBoard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["science", "development"],
                Tags = ["computing", "electricity", "electronics"],
            },
            LucideIconKind.Citrus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["lemon", "orange", "grapefruit", "fruit"],
            },
            LucideIconKind.Clapperboard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "ericfennis", "danielbayley"],
                Categories = ["multimedia"],
                Tags = ["movie", "film", "video", "camera", "cinema", "cut", "action", "television", "tv", "show", "entertainment"],
            },
            LucideIconKind.Clipboard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["copy", "paste"],
            },
            LucideIconKind.ClipboardCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["copied", "pasted", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.ClipboardClock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["beanduong", "colebemis", "csandman", "ericfennis", "karsa-mistmere", "jamiemlaw"],
                Categories = ["time", "text"],
                Tags = ["copy", "paste", "history", "log", "clock", "time", "watch", "alarm", "hour", "minute", "reminder", "scheduled", "deadline", "pending", "time tracking", "timesheets", "appointment", "logbook"],
            },
            LucideIconKind.ClipboardCopy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["copy", "paste"],
            },
            LucideIconKind.ClipboardList => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["copy", "paste", "tasks"],
            },
            LucideIconKind.ClipboardMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "medical"],
                Tags = ["copy", "delete", "remove", "erase", "document", "medical", "report", "doctor"],
            },
            LucideIconKind.ClipboardPaste => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["xnousnow", "ericfennis", "jguddas"],
                Categories = ["text", "arrows"],
                Tags = ["copy", "paste"],
            },
            LucideIconKind.ClipboardPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["text"],
                Tags = ["paste", "signature"],
            },
            LucideIconKind.ClipboardPenLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["text"],
                Tags = ["paste"],
            },
            LucideIconKind.ClipboardPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "medical"],
                Tags = ["copy", "paste", "add", "create", "new", "document", "medical", "report", "doctor"],
            },
            LucideIconKind.ClipboardType => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["text"],
                Tags = ["paste", "format", "text"],
            },
            LucideIconKind.ClipboardX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["copy", "paste", "discard", "remove"],
            },
            LucideIconKind.Clock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock10 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock11 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock12 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm", "noon", "midnight"],
            },
            LucideIconKind.Clock2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock5 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock6 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock7 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock8 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.Clock9 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.ClockAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm", "warning", "wrong"],
            },
            LucideIconKind.ClockArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm", "sort", "order", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ClockArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm", "sort", "order", "ascending", "descending", "increasing", "decreasing", "rising", "falling"],
            },
            LucideIconKind.ClockFading => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm"],
            },
            LucideIconKind.ClockPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "gubser"],
                Categories = ["time"],
                Tags = ["time", "watch", "alarm", "add", "create", "new"],
            },
            LucideIconKind.ClosedCaption => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "UsamaKhan"],
                Categories = ["accessibility", "multimedia"],
                Tags = ["tv", "movie", "video", "closed captions", "subtitles", "subhead", "transcription", "transcribe", "dialogue", "accessibility"],
            },
            LucideIconKind.Cloud => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather"],
            },
            LucideIconKind.CloudAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "lscheibel"],
                Categories = ["development"],
                Tags = ["weather", "danger", "warning", "alert", "error", "sync", "network", "exclamation"],
            },
            LucideIconKind.CloudCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas", "lscheibel"],
                Categories = ["development"],
                Tags = ["sync", "network", "success", "done", "completed", "saved", "persisted"],
            },
            LucideIconKind.CloudCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "UsamaKhan"],
                Categories = ["development"],
                Tags = ["computing", "ai", "cluster", "network"],
            },
            LucideIconKind.CloudDownload => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["arrows", "files"],
                Tags = ["import"],
            },
            LucideIconKind.CloudDrizzle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "shower"],
            },
            LucideIconKind.CloudFog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "mittalyashu"],
                Categories = ["weather"],
                Tags = ["weather", "mist"],
            },
            LucideIconKind.CloudHail => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "rainfall"],
            },
            LucideIconKind.CloudLightning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "bolt"],
            },
            LucideIconKind.CloudMoon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["weather"],
                Tags = ["weather", "night"],
            },
            LucideIconKind.CloudMoonRain => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "karsa-mistmere", "jguddas"],
                Categories = ["weather"],
                Tags = ["weather", "partly", "night", "rainfall"],
            },
            LucideIconKind.CloudOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["connectivity", "weather"],
                Tags = ["disconnect"],
            },
            LucideIconKind.CloudRain => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "rainfall"],
            },
            LucideIconKind.CloudRainWind => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "rainfall"],
            },
            LucideIconKind.CloudSnow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "blizzard"],
            },
            LucideIconKind.CloudSun => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "partly"],
            },
            LucideIconKind.CloudSunRain => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "partly", "rainfall"],
            },
            LucideIconKind.CloudUpload => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["arrows", "files"],
                Tags = ["file"],
            },
            LucideIconKind.Cloudy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "clouds"],
            },
            LucideIconKind.Clover => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "jguddas"],
                Categories = ["gaming"],
                Tags = ["leaf", "luck", "plant"],
            },
            LucideIconKind.Club => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "gaming"],
                Tags = ["shape", "suit", "playing", "cards"],
            },
            LucideIconKind.Code => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["text", "development"],
                Tags = ["source", "programming", "html", "xml"],
            },
            LucideIconKind.CodeXml => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["text", "development"],
                Tags = ["source", "programming", "html", "xml"],
            },
            LucideIconKind.Codepen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["brands", "development"],
                Tags = ["logo"],
            },
            LucideIconKind.Codesandbox => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["brands", "development"],
                Tags = ["logo"],
            },
            LucideIconKind.Coffee => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["drink", "cup", "mug", "tea", "cafe", "hot", "beverage"],
            },
            LucideIconKind.Cog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["computing", "settings", "cog", "edit", "gear", "preferences", "controls", "configuration", "fixed", "build", "construction", "parts"],
            },
            LucideIconKind.Coins => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "ericfennis", "karsa-mistmere"],
                Categories = ["gaming"],
                Tags = ["money", "cash", "finance", "gamble"],
            },
            LucideIconKind.Columns2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zenoamaro", "ericfennis", "csandman", "mittalyashu"],
                Categories = ["layout", "design", "text"],
                Tags = ["lines", "list", "queue", "preview", "panel", "parallel", "series", "split", "vertical", "horizontal", "half", "center", "middle", "even", "sidebar", "drawer", "gutter", "fold", "reflow", "typography", "pagination", "pages"],
            },
            LucideIconKind.Columns3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "text"],
                Tags = ["lines", "list", "queue", "preview", "parallel", "series", "split", "vertical", "horizontal", "thirds", "triple", "center", "middle", "alignment", "even", "sidebars", "drawers", "gutters", "fold", "reflow", "typography", "pagination", "pages"],
            },
            LucideIconKind.Columns3Cog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["irvineacosta", "danielbayley", "karsa-mistmere"],
                Categories = ["layout", "design"],
                Tags = ["columns", "settings", "customize", "table", "grid", "adjust", "configuration", "panel", "layout"],
            },
            LucideIconKind.Columns4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "text", "security"],
                Tags = ["lines", "list", "queue", "preview", "parallel", "series", "split", "vertical", "horizontal", "thirds", "triple", "center", "middle", "alignment", "even", "sidebars", "drawers", "gutters", "fold", "reflow", "typography", "pagination", "pages", "prison", "jail", "bars", "sentence", "police", "cops", "cell", "crime", "criminal", "justice", "law", "enforcement", "grill"],
            },
            LucideIconKind.Combine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "jguddas"],
                Categories = ["development", "files"],
                Tags = ["cubes", "packages", "parts", "units", "collection", "cluster", "combine", "gather", "merge"],
            },
            LucideIconKind.Command => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["development"],
                Tags = ["keyboard", "key", "mac", "cmd", "button"],
            },
            LucideIconKind.Compass => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["navigation", "travel"],
                Tags = ["direction", "north", "east", "south", "west", "safari", "browser"],
            },
            LucideIconKind.Component => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["design", "development"],
                Tags = ["design", "element", "group", "module", "part", "symbol"],
            },
            LucideIconKind.Computer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "development", "gaming"],
                Tags = ["pc", "chassis", "codespaces", "github"],
            },
            LucideIconKind.ConciergeBell => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["travel"],
                Tags = ["reception", "bell", "porter"],
            },
            LucideIconKind.Cone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "math"],
                Tags = ["conical", "triangle", "triangular", "geometry", "filter", "funnel", "hopper", "spotlight", "searchlight"],
            },
            LucideIconKind.Construction => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["development"],
                Tags = ["roadwork", "maintenance", "blockade", "barricade"],
            },
            LucideIconKind.Contact => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "karsa-mistmere", "FPDK", "ericfennis", "jguddas"],
                Categories = ["account", "connectivity", "communication", "social"],
                Tags = ["user", "person", "family", "friend", "acquaintance", "listing", "networking"],
            },
            LucideIconKind.ContactRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["account", "connectivity", "communication", "social"],
                Tags = ["user", "person", "family", "friend", "acquaintance", "listing", "networking"],
            },
            LucideIconKind.Container => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "transportation", "mail"],
                Tags = ["storage", "shipping", "freight", "supply chain", "docker", "environment", "devops", "code", "coding"],
            },
            LucideIconKind.Contrast => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "csandman", "ericfennis"],
                Categories = ["photography", "accessibility", "design"],
                Tags = ["display", "accessibility"],
            },
            LucideIconKind.Cookie => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "ericfennis"],
                Categories = ["account", "food-beverage"],
                Tags = ["biscuit", "privacy", "legal", "food"],
            },
            LucideIconKind.CookingPot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["guillermo-angeles", "ericfennis"],
                Categories = ["food-beverage", "home"],
                Tags = ["pod", "cooking", "recipe", "food", "kitchen", "chef", "restaurant", "dinner", "lunch", "breakfast", "meal", "eat"],
            },
            LucideIconKind.Copy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley", "jguddas"],
                Categories = ["text"],
                Tags = ["clone", "duplicate", "multiple"],
            },
            LucideIconKind.CopyCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "notifications"],
                Tags = ["clone", "duplicate", "done", "multiple"],
            },
            LucideIconKind.CopyMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "math"],
                Tags = ["clone", "duplicate", "remove", "delete", "collapse", "subtract", "multiple", "-"],
            },
            LucideIconKind.CopyPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "math"],
                Tags = ["clone", "duplicate", "add", "multiple", "expand", "+"],
            },
            LucideIconKind.CopySlash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "development", "math"],
                Tags = ["clone", "duplicate", "cancel", "ban", "no", "stop", "forbidden", "prohibited", "error", "multiple", "divide", "division", "split", "or", "/"],
            },
            LucideIconKind.CopyX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["notifications", "math"],
                Tags = ["cancel", "close", "delete", "remove", "clear", "multiple", "multiply", "multiplication", "times"],
            },
            LucideIconKind.Copyleft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "csandman"],
                Categories = ["text"],
                Tags = ["licence"],
            },
            LucideIconKind.Copyright => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "csandman"],
                Categories = ["text"],
                Tags = ["licence", "license"],
            },
            LucideIconKind.CornerDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow", "return"],
            },
            LucideIconKind.CornerDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "text", "development"],
                Tags = ["arrow", "indent", "tab"],
            },
            LucideIconKind.CornerLeftDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.CornerLeftUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.CornerRightDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.CornerRightUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.CornerUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.CornerUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows"],
                Tags = ["arrow"],
            },
            LucideIconKind.Cpu => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["devices"],
                Tags = ["processor", "cores", "technology", "computer", "chip", "circuit", "memory", "ram", "specs", "gigahertz", "ghz"],
            },
            LucideIconKind.CreativeCommons => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["licence", "license"],
            },
            LucideIconKind.CreditCard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["account", "finance"],
                Tags = ["bank", "purchase", "payment", "cc"],
            },
            LucideIconKind.Croissant => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["bakery", "cooking", "food", "pastry"],
            },
            LucideIconKind.Crop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["photography", "design"],
                Tags = ["photo", "image"],
            },
            LucideIconKind.Cross => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "ericfennis"],
                Categories = ["shapes"],
                Tags = ["healthcare", "first aid"],
            },
            LucideIconKind.Crosshair => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["photography"],
                Tags = ["aim", "target"],
            },
            LucideIconKind.Crown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["gaming"],
                Tags = ["diadem", "tiara", "circlet", "corona", "king", "ruler", "winner", "favourite"],
            },
            LucideIconKind.Cuboid => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "math", "buildings"],
                Tags = ["brick", "block", "container", "storage", "geometry", "rectangular", "hexahedron"],
            },
            LucideIconKind.CupSoda => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["beverage", "cup", "drink", "soda", "straw", "water"],
            },
            LucideIconKind.Currency => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["connium", "ericfennis"],
                Categories = ["finance"],
                Tags = ["finance", "money"],
            },
            LucideIconKind.Cylinder => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "design", "math"],
                Tags = ["shape", "elliptical", "geometry", "container", "storage", "tin", "pot"],
            },
            LucideIconKind.Dam => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev"],
                Categories = ["buildings", "sustainability"],
                Tags = ["electricity", "energy", "water"],
            },
            LucideIconKind.Database => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["devices", "development"],
                Tags = ["storage", "memory", "container", "tin", "pot", "bytes", "servers"],
            },
            LucideIconKind.DatabaseBackup => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas", "danielbayley", "karsa-mistmere"],
                Categories = ["devices", "arrows", "design", "development", "photography"],
                Tags = ["storage", "memory", "bytes", "servers", "backup", "timemachine", "rotate", "arrow", "left"],
            },
            LucideIconKind.DatabaseZap => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "development"],
                Tags = ["cache busting", "storage", "memory", "bytes", "servers", "power", "crash"],
            },
            LucideIconKind.DecimalsArrowLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "karsa-mistmere"],
                Categories = ["design", "text", "arrows", "math"],
                Tags = ["numerical", "decimal", "decrease", "less", "fewer", "precision", "rounding", "digits", "fraction", "float", "number"],
            },
            LucideIconKind.DecimalsArrowRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "karsa-mistmere"],
                Categories = ["design", "text", "arrows", "math"],
                Tags = ["numerical", "decimal", "increase", "more", "precision", "rounding", "digits", "fraction", "float", "number"],
            },
            LucideIconKind.Delete => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["text", "arrows"],
                Tags = ["backspace", "remove"],
            },
            LucideIconKind.Dessert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["pudding", "christmas", "xmas", "custard", "iced bun", "icing", "fondant", "cake", "ice cream", "gelato", "sundae", "scoop", "dollop", "sugar", "food", "sweet"],
            },
            LucideIconKind.Diameter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "math", "design", "tools"],
                Tags = ["shape", "circle", "geometry", "trigonometry", "width", "height", "size", "calculate", "measure"],
            },
            LucideIconKind.Diamond => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["shapes", "gaming"],
                Tags = ["square", "rectangle", "oblique", "rhombus", "shape", "suit", "playing", "cards"],
            },
            LucideIconKind.DiamondMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["multimedia", "photography", "tools", "devices"],
                Tags = ["keyframe", "subtract", "remove", "decrease", "reduce", "calculator", "button", "keyboard", "line", "divider", "separator", "horizontal rule", "hr", "html", "markup", "markdown", "---", "toolbar", "operator", "code", "coding", "minimum", "downgrade"],
            },
            LucideIconKind.DiamondPercent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["social", "finance", "shopping", "math"],
                Tags = ["verified", "unverified", "sale", "discount", "offer", "marketing", "sticker", "price tag"],
            },
            LucideIconKind.DiamondPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["multimedia", "photography", "tools", "devices"],
                Tags = ["keyframe", "add", "new", "increase", "increment", "positive", "calculate", "toolbar", "crosshair", "aim", "target", "scope", "sight", "reticule", "maximum", "upgrade", "extra", "+"],
            },
            LucideIconKind.Dice1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "1", "board", "game"],
            },
            LucideIconKind.Dice2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "2", "board", "game"],
            },
            LucideIconKind.Dice3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "3", "board", "game"],
            },
            LucideIconKind.Dice4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "4", "board", "game"],
            },
            LucideIconKind.Dice5 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "5", "board", "game"],
            },
            LucideIconKind.Dice6 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "6", "board", "game"],
            },
            LucideIconKind.Dices => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["dice", "random", "tabletop", "board", "game"],
            },
            LucideIconKind.Diff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["development", "files"],
                Tags = ["patch", "difference", "compare", "plus", "minus", "plus-minus", "math"],
            },
            LucideIconKind.Disc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "danielbayley", "jguddas", "ericfennis"],
                Categories = ["devices", "multimedia"],
                Tags = ["album", "music", "songs", "format", "cd", "dvd", "vinyl", "sleeve", "cover", "platinum", "compilation", "ep", "recording", "playback", "spin", "rotate", "rpm", "dj"],
            },
            LucideIconKind.Disc2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "ericfennis"],
                Categories = ["devices", "multimedia"],
                Tags = ["album", "music", "vinyl", "record", "cd", "dvd", "format", "dj", "spin", "rotate", "rpm"],
            },
            LucideIconKind.Disc3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "multimedia"],
                Tags = ["album", "music", "vinyl", "record", "cd", "dvd", "format", "dj", "spin", "rotate", "rpm"],
            },
            LucideIconKind.DiscAlbum => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "multimedia"],
                Tags = ["album", "music", "songs", "format", "cd", "dvd", "vinyl", "sleeve", "cover", "platinum", "compilation", "ep", "recording", "playback", "spin", "rotate", "rpm", "dj"],
            },
            LucideIconKind.Divide => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis"],
                Categories = ["math", "development"],
                Tags = ["calculate", "math", "division", "operator", "code", "÷", "/"],
            },
            LucideIconKind.Dna => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["medical"],
                Tags = ["gene", "gmo", "helix", "heredity", "chromosome", "nucleic acid"],
            },
            LucideIconKind.DnaOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["medical", "food-beverage"],
                Tags = ["gene", "gmo free", "helix", "heredity", "chromosome", "nucleic acid"],
            },
            LucideIconKind.Dock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "files"],
                Tags = ["desktop", "applications", "launch", "home", "menu bar", "bottom", "line", "macos", "osx"],
            },
            LucideIconKind.Dog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie", "jguddas"],
                Categories = ["animals"],
                Tags = ["animal", "pet", "puppy", "hound", "canine"],
            },
            LucideIconKind.DollarSign => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Donut => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage"],
                Tags = ["doughnut", "sprinkles", "topping", "fast food", "junk food", "snack", "treat", "sweet", "sugar", "dessert", "hollow", "ring"],
            },
            LucideIconKind.DoorClosed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home", "travel", "security"],
                Tags = ["entrance", "entry", "exit", "ingress", "egress", "gate", "gateway", "emergency exit"],
            },
            LucideIconKind.DoorClosedLocked => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "lukedukeus"],
                Categories = ["home", "travel", "security"],
                Tags = ["entrance", "entry", "exit", "ingress", "egress", "gate", "gateway", "emergency exit", "lock"],
            },
            LucideIconKind.DoorOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home", "travel", "security"],
                Tags = ["entrance", "entry", "exit", "ingress", "egress", "gate", "gateway", "emergency exit"],
            },
            LucideIconKind.Dot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "text"],
                Tags = ["interpunct", "interpoint", "middot", "step", "punctuation", "period", "full stop", "end", "finish", "final", "characters", "font", "typography", "type", "center", "."],
            },
            LucideIconKind.Download => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "files"],
                Tags = ["import", "export", "save"],
            },
            LucideIconKind.DraftingCompass => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["math", "design", "tools"],
                Tags = ["geometry", "trigonometry", "radius", "diameter", "circumference", "calculate", "measure", "arc", "curve", "draw", "sketch"],
            },
            LucideIconKind.Drama => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia"],
                Tags = ["drama", "masks", "theater", "theatre", "entertainment", "show"],
            },
            LucideIconKind.Dribbble => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4"],
                Categories = ["brands", "social", "design"],
                Tags = ["design", "social"],
            },
            LucideIconKind.Drill => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["tools", "home", "devices"],
                Tags = ["power", "bit", "head", "hole", "diy", "toolbox", "build", "construction"],
            },
            LucideIconKind.Drone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["bernatfortet", "shopped", "karsa-mistmere", "jguddas"],
                Categories = ["transportation", "devices"],
                Tags = ["quadcopter", "uav", "aerial", "flight", "flying", "technology", "airborne", "robotics"],
            },
            LucideIconKind.Droplet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "johnletey"],
                Categories = ["weather", "gaming"],
                Tags = ["water", "weather", "liquid", "fluid", "wet", "moisture", "damp", "bead", "globule"],
            },
            LucideIconKind.DropletOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "johnletey", "jguddas", "Footagesus"],
                Categories = ["weather", "gaming"],
                Tags = ["water", "weather", "liquid", "fluid", "wet", "moisture", "damp", "bead", "globule"],
            },
            LucideIconKind.Droplets => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis"],
                Categories = ["weather"],
                Tags = ["water", "weather", "liquid", "fluid", "wet", "moisture", "damp", "bead", "globule"],
            },
            LucideIconKind.Drum => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "devices"],
                Tags = ["drummer", "kit", "sticks", "instrument", "beat", "bang", "bass", "backing track", "band", "play", "performance", "concert", "march", "music", "audio", "sound", "noise", "loud"],
            },
            LucideIconKind.Drumstick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["food", "chicken", "meat"],
            },
            LucideIconKind.Dumbbell => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "karsa-mistmere"],
                Categories = ["navigation", "sports"],
                Tags = ["barbell", "weight", "workout", "gym"],
            },
            LucideIconKind.Ear => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["medical", "accessibility"],
                Tags = ["hearing", "noise", "audio", "accessibility"],
            },
            LucideIconKind.EarOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["medical", "accessibility"],
                Tags = ["hearing", "hard of hearing", "hearing loss", "deafness", "noise", "silence", "audio", "accessibility"],
            },
            LucideIconKind.Earth => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["world", "browser", "language", "translate", "globe"],
            },
            LucideIconKind.EarthLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["security", "development", "devices"],
                Tags = ["vpn", "private", "privacy", "network", "world", "browser", "security", "encryption", "protection", "connection"],
            },
            LucideIconKind.Eclipse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["science", "design", "development", "accessibility", "photography"],
                Tags = ["lunar", "solar", "crescent moon", "sun", "earth", "day", "night", "planet", "space", "mode", "dark", "light", "toggle", "switch", "color", "css", "styles", "display", "accessibility", "contrast", "brightness", "blend", "shade"],
            },
            LucideIconKind.Egg => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "Andreto", "ericfennis", "jamiemlaw"],
                Categories = ["food-beverage", "animals"],
                Tags = ["bird", "chicken", "nest", "hatch", "shell", "incubate", "soft boiled", "hard", "breakfast", "brunch", "morning", "easter"],
            },
            LucideIconKind.EggFried => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["food-beverage"],
                Tags = ["food", "breakfast"],
            },
            LucideIconKind.EggOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["food-beverage"],
                Tags = ["egg free", "vegan", "hatched", "bad egg"],
            },
            LucideIconKind.Ellipsis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["layout", "development"],
                Tags = ["et cetera", "etc", "loader", "loading", "progress", "pending", "throbber", "menu", "options", "operator", "code", "coding", "spread", "rest", "more", "further", "extra", "overflow", "dots", "…", "..."],
            },
            LucideIconKind.EllipsisVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["layout"],
                Tags = ["menu", "options", "spread", "more", "further", "extra", "overflow", "dots", "…", "..."],
            },
            LucideIconKind.Equal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["math", "development"],
                Tags = ["calculate", "math", "operator", "assignment", "code", "="],
            },
            LucideIconKind.EqualApproximately => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ksk3110"],
                Categories = ["math"],
                Tags = ["about", "calculate", "math", "operater"],
            },
            LucideIconKind.EqualNot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["math", "development"],
                Tags = ["calculate", "off", "math", "operator", "code", "≠"],
            },
            LucideIconKind.Eraser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["maxwellito", "karsa-mistmere", "jguddas"],
                Categories = ["text"],
                Tags = ["pencil", "drawing", "undo", "delete", "clear", "trash", "remove"],
            },
            LucideIconKind.EthernetPort => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["communication", "devices", "multimedia", "gaming"],
                Tags = ["internet", "network", "connection", "cable", "lan", "port", "router", "switch", "hub", "modem", "web", "online", "networking", "communication", "socket", "plug", "slot", "controller", "connector", "interface", "console", "signal", "data", "input", "output"],
            },
            LucideIconKind.Euro => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.EvCharger => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["UsamaKhan", "karsa-mistmere", "ericfennis", "colebemis", "csandman", "johnletey"],
                Categories = ["transportation", "navigation"],
                Tags = ["electric", "charger", "station", "vehicle", "fast", "plug", "ev", "power", "electricity", "energy", "accumulator", "charge"],
            },
            LucideIconKind.Expand => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas"],
                Categories = ["text", "arrows"],
                Tags = ["scale", "fullscreen", "maximize", "minimize", "contract"],
            },
            LucideIconKind.ExternalLink => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "text", "social"],
                Tags = ["outbound", "open", "share"],
            },
            LucideIconKind.Eye => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["accessibility", "photography", "design", "security"],
                Tags = ["view", "watch", "see", "show", "expose", "reveal", "display", "visible", "visibility", "vision", "preview", "read"],
            },
            LucideIconKind.EyeClosed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["accessibility", "photography", "design", "security"],
                Tags = ["view", "watch", "see", "hide", "conceal", "mask", "hidden", "visibility", "vision"],
            },
            LucideIconKind.EyeOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["accessibility", "photography", "design", "security"],
                Tags = ["view", "watch", "see", "hide", "conceal", "mask", "hidden", "visibility", "vision"],
            },
            LucideIconKind.Facebook => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["social", "brands"],
                Tags = ["logo", "social"],
            },
            LucideIconKind.Factory => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["buildings"],
                Tags = ["building", "business", "energy", "industry", "manufacture", "sector"],
            },
            LucideIconKind.Fan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home"],
                Tags = ["air", "cooler", "ventilation", "ventilator", "blower"],
            },
            LucideIconKind.FastForward => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["multimedia", "arrows"],
                Tags = ["music"],
            },
            LucideIconKind.Feather => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["logo"],
            },
            LucideIconKind.Fence => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["home", "buildings"],
                Tags = ["picket", "panels", "woodwork", "diy", "materials", "suburban", "garden", "property", "territory"],
            },
            LucideIconKind.FerrisWheel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["big wheel", "daisy wheel", "observation", "attraction", "entertainment", "amusement park", "theme park", "funfair"],
            },
            LucideIconKind.Figma => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["brands", "design"],
                Tags = ["logo", "design", "tool"],
            },
            LucideIconKind.File => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["document"],
            },
            LucideIconKind.FileArchive => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["zip", "package", "archive"],
            },
            LucideIconKind.FileAudio => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["music", "audio", "sound", "headphones"],
            },
            LucideIconKind.FileAudio2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["music", "audio", "sound", "headphones"],
            },
            LucideIconKind.FileAxis3d => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["design", "files"],
                Tags = ["model", "3d", "axis", "coordinates"],
            },
            LucideIconKind.FileBadge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["award", "achievement", "badge", "rosette", "prize", "winner"],
            },
            LucideIconKind.FileBadge2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["award", "achievement", "badge", "rosette", "prize", "winner"],
            },
            LucideIconKind.FileBox => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["box", "package", "model"],
            },
            LucideIconKind.FileChartColumn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["statistics", "analytics", "diagram", "graph", "presentation"],
            },
            LucideIconKind.FileChartColumnIncreasing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["statistics", "analytics", "diagram", "graph", "presentation", "trending up"],
            },
            LucideIconKind.FileChartLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["statistics", "analytics", "diagram", "graph", "presentation"],
            },
            LucideIconKind.FileChartPie => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["statistics", "analytics", "diagram", "graph", "presentation"],
            },
            LucideIconKind.FileCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["done", "document", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.FileCheck2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["done", "document", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.FileClock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jamiemlaw"],
                Categories = ["files", "time"],
                Tags = ["history", "log", "clock"],
            },
            LucideIconKind.FileCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["script", "document", "gist", "html", "xml", "property list", "plist"],
            },
            LucideIconKind.FileCode2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "karsa-mistmere"],
                Categories = ["files", "development"],
                Tags = ["script", "document", "html", "xml", "property list", "plist"],
            },
            LucideIconKind.FileCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas", "UsamaKhan"],
                Categories = ["files"],
                Tags = ["executable", "settings", "cog", "edit", "gear"],
            },
            LucideIconKind.FileDiff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["diff", "patch"],
            },
            LucideIconKind.FileDigit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["number", "document"],
            },
            LucideIconKind.FileDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "arrows"],
                Tags = ["download", "import", "export"],
            },
            LucideIconKind.FileHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["heart", "favourite", "bookmark", "quick link"],
            },
            LucideIconKind.FileImage => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["image", "graphics", "photo", "picture"],
            },
            LucideIconKind.FileInput => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files", "arrows"],
                Tags = ["document"],
            },
            LucideIconKind.FileJson => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["code", "json", "curly braces", "curly brackets"],
            },
            LucideIconKind.FileJson2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["code", "json", "curly braces", "curly brackets"],
            },
            LucideIconKind.FileKey => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "security"],
                Tags = ["key", "private", "public", "security"],
            },
            LucideIconKind.FileKey2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "security"],
                Tags = ["key", "private", "public", "security"],
            },
            LucideIconKind.FileLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files", "security"],
                Tags = ["lock", "password", "security"],
            },
            LucideIconKind.FileLock2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files", "security"],
                Tags = ["lock", "password", "security"],
            },
            LucideIconKind.FileMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["delete", "remove", "erase", "document"],
            },
            LucideIconKind.FileMinus2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["document"],
            },
            LucideIconKind.FileMusic => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["files", "multimedia"],
                Tags = ["audio", "sound", "noise", "track", "digital", "recording", "playback", "piano", "keyboard", "keys", "notes", "chord", "midi", "octave"],
            },
            LucideIconKind.FileOutput => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["document"],
            },
            LucideIconKind.FilePen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["signature"],
            },
            LucideIconKind.FilePenLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["files"],
                Tags = ["edit"],
            },
            LucideIconKind.FilePlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["movie", "video", "film"],
            },
            LucideIconKind.FilePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["add", "create", "new", "document"],
            },
            LucideIconKind.FilePlus2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["add", "create", "new", "document"],
            },
            LucideIconKind.FileQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["readme", "help", "question"],
            },
            LucideIconKind.FileScan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["scan", "code", "qr-code"],
            },
            LucideIconKind.FileSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["lost", "document", "find", "browser", "lens"],
            },
            LucideIconKind.FileSearch2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["lost", "document", "find", "browser", "lens"],
            },
            LucideIconKind.FileSliders => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files", "development"],
                Tags = ["cogged", "gear", "mechanical", "machinery", "configuration", "controls", "preferences", "settings", "system", "admin", "edit", "executable"],
            },
            LucideIconKind.FileSpreadsheet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files"],
                Tags = ["spreadsheet", "sheet", "table"],
            },
            LucideIconKind.FileStack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["files", "development"],
                Tags = ["versions", "multiple", "copy", "documents", "revisions", "version control", "history"],
            },
            LucideIconKind.FileSymlink => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["symlink", "symbolic", "link"],
            },
            LucideIconKind.FileTerminal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "development"],
                Tags = ["terminal", "bash", "script", "executable"],
            },
            LucideIconKind.FileText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["files", "text"],
                Tags = ["data", "txt", "pdf", "document"],
            },
            LucideIconKind.FileType => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "text"],
                Tags = ["font", "text", "typography", "type"],
            },
            LucideIconKind.FileType2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "text"],
                Tags = ["font", "text", "typography", "type"],
            },
            LucideIconKind.FileUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "arrows"],
                Tags = ["upload", "import", "export"],
            },
            LucideIconKind.FileUser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "colebemis", "ericfennis", "jguddas"],
                Categories = ["account", "files"],
                Tags = ["person", "personal information", "people", "listing", "networking", "document", "contact", "cover letter", "resume", "cv", "curriculum vitae", "application form"],
            },
            LucideIconKind.FileVideoCamera => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["movie", "video", "film"],
            },
            LucideIconKind.FileVolume => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["files"],
                Tags = ["audio", "music", "volume"],
            },
            LucideIconKind.FileVolume2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["audio", "music", "volume"],
            },
            LucideIconKind.FileWarning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["files", "notifications"],
                Tags = ["hidden", "warning", "alert", "danger", "protected", "exclamation mark"],
            },
            LucideIconKind.FileX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["lost", "delete", "remove", "document"],
            },
            LucideIconKind.FileX2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["files"],
                Tags = ["lost", "delete", "remove", "document"],
            },
            LucideIconKind.Files => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["multiple", "copy", "documents"],
            },
            LucideIconKind.Film => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["photography", "multimedia"],
                Tags = ["movie", "video", "reel", "camera", "cinema", "entertainment"],
            },
            LucideIconKind.Fingerprint => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["account", "security", "medical", "devices"],
                Tags = ["2fa", "authentication", "biometric", "identity", "security"],
            },
            LucideIconKind.FireExtinguisher => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["home", "tools", "travel"],
                Tags = ["flames", "smoke", "foam", "water", "spray", "hose", "firefighter", "fireman", "department", "brigade", "station", "emergency", "suppress", "compressed", "tank", "cylinder", "safety", "equipment", "amenities"],
            },
            LucideIconKind.Fish => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie"],
                Categories = ["food-beverage", "animals"],
                Tags = ["dish", "restaurant", "course", "meal", "seafood", "pet", "sea", "marine"],
            },
            LucideIconKind.FishOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "kemie", "ericfennis"],
                Categories = ["food-beverage", "animals"],
                Tags = ["food", "dish", "restaurant", "course", "meal", "seafood", "animal", "pet", "sea", "marine", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.FishSymbol => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage", "animals"],
                Tags = ["dish", "restaurant", "course", "meal", "seafood", "pet", "sea", "marine"],
            },
            LucideIconKind.Flag => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jamiemlaw"],
                Categories = ["account", "social"],
                Tags = ["report", "marker", "notification", "warning", "milestone", "goal", "notice", "signal", "attention", "banner"],
            },
            LucideIconKind.FlagOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "cyberalien", "ericfennis", "jamiemlaw"],
                Categories = ["account", "social"],
                Tags = ["unflag", "unmark", "report", "marker", "notification", "warning", "milestone", "goal", "notice", "signal", "attention", "banner"],
            },
            LucideIconKind.FlagTriangleLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["tidoni", "ericfennis", "jamiemlaw"],
                Categories = ["development", "navigation"],
                Tags = ["report", "timeline", "marker", "pin"],
            },
            LucideIconKind.FlagTriangleRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["tidoni", "ericfennis", "jamiemlaw"],
                Categories = ["development", "navigation"],
                Tags = ["report", "timeline", "marker", "pin"],
            },
            LucideIconKind.Flame => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "csandman", "jamiemlaw"],
                Categories = ["weather", "social", "gaming"],
                Tags = ["heat", "burn", "light", "glow", "ignite", "passion", "ember", "fire", "lit", "burning", "spark", "embers", "smoke", "firefighter", "fireman", "department", "brigade", "station", "emergency"],
            },
            LucideIconKind.FlameKindling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["nature", "social", "gaming"],
                Tags = ["campfire", "camping", "wilderness", "outdoors", "lit", "warmth", "wood", "twigs", "sticks"],
            },
            LucideIconKind.Flashlight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis"],
                Categories = ["photography", "devices"],
                Tags = ["torch"],
            },
            LucideIconKind.FlashlightOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere", "csandman"],
                Categories = ["photography", "devices"],
                Tags = ["torch"],
            },
            LucideIconKind.FlaskConical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere", "jamiemlaw"],
                Categories = ["science", "gaming"],
                Tags = ["beaker", "erlenmeyer", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.FlaskConicalOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["science", "gaming"],
                Tags = ["beaker", "erlenmeyer", "non toxic", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.FlaskRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["science", "gaming"],
                Tags = ["beaker", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.FlipHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["design", "photography"],
                Tags = ["reflect", "mirror", "alignment", "dashed"],
            },
            LucideIconKind.FlipHorizontal2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["design", "photography"],
                Tags = ["reflect", "mirror", "alignment", "dashed"],
            },
            LucideIconKind.FlipVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["design", "photography"],
                Tags = ["reflect", "mirror", "alignment", "dashed"],
            },
            LucideIconKind.FlipVertical2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["design", "photography"],
                Tags = ["reflect", "mirror", "alignment", "dashed"],
            },
            LucideIconKind.Flower => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["nature", "gaming", "sustainability"],
                Tags = ["sustainability", "nature", "plant", "spring"],
            },
            LucideIconKind.Flower2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["nature", "sustainability", "seasons"],
                Tags = ["sustainability", "nature", "plant"],
            },
            LucideIconKind.Focus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas", "ericfennis"],
                Categories = ["photography"],
                Tags = ["camera", "lens", "photo", "dashed"],
            },
            LucideIconKind.FoldHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "layout"],
                Tags = ["arrow", "collapse", "fold", "vertical", "dashed"],
            },
            LucideIconKind.FoldVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "layout"],
                Tags = ["arrow", "collapse", "fold", "vertical", "dashed"],
            },
            LucideIconKind.Folder => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory"],
            },
            LucideIconKind.FolderArchive => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["archive", "zip", "package"],
            },
            LucideIconKind.FolderCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["files"],
                Tags = ["done", "directory", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.FolderClock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "jamiemlaw"],
                Categories = ["files", "time"],
                Tags = ["history", "directory", "clock"],
            },
            LucideIconKind.FolderClosed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["files"],
                Tags = ["directory", "closed"],
            },
            LucideIconKind.FolderCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files", "development"],
                Tags = ["directory", "coding", "develop", "software"],
            },
            LucideIconKind.FolderCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "UsamaKhan"],
                Categories = ["files"],
                Tags = ["directory", "settings", "control", "preferences", "cog", "edit", "gear"],
            },
            LucideIconKind.FolderDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files", "development"],
                Tags = ["directory", "root", "project", "pinned", "active", "current", "cogged", "gear", "mechanical", "machinery", "configuration", "controls", "preferences", "settings", "system", "admin", "edit"],
            },
            LucideIconKind.FolderDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["directory", "download", "import", "export"],
            },
            LucideIconKind.FolderGit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["files"],
                Tags = ["directory", "root", "project", "git", "repo"],
            },
            LucideIconKind.FolderGit2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["files"],
                Tags = ["directory", "root", "project", "git", "repo"],
            },
            LucideIconKind.FolderHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "heart", "favourite", "bookmark", "quick link"],
            },
            LucideIconKind.FolderInput => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["directory", "import", "export"],
            },
            LucideIconKind.FolderKanban => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["charts", "development", "design", "files"],
                Tags = ["projects", "manage", "overview", "board", "tickets", "issues", "roadmap", "plan", "intentions", "productivity", "work", "agile", "code", "coding", "directory", "project", "root"],
            },
            LucideIconKind.FolderKey => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["files", "security"],
                Tags = ["directory", "key", "private", "security", "protected"],
            },
            LucideIconKind.FolderLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["files", "security"],
                Tags = ["directory", "lock", "private", "security", "protected"],
            },
            LucideIconKind.FolderMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "remove", "delete"],
            },
            LucideIconKind.FolderOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory"],
            },
            LucideIconKind.FolderOpenDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files", "development"],
                Tags = ["directory", "root", "project", "active", "current", "pinned"],
            },
            LucideIconKind.FolderOutput => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["directory", "import", "export"],
            },
            LucideIconKind.FolderPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "rename"],
            },
            LucideIconKind.FolderPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "add", "create", "new"],
            },
            LucideIconKind.FolderRoot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files", "development"],
                Tags = ["directory", "root", "project", "git", "repo"],
            },
            LucideIconKind.FolderSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["directory", "search", "find", "lost", "browser", "lens"],
            },
            LucideIconKind.FolderSearch2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "search", "find", "lost", "browser", "lens"],
            },
            LucideIconKind.FolderSymlink => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["directory", "symlink", "symbolic", "link"],
            },
            LucideIconKind.FolderSync => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["directory", "synchronize", "synchronise", "refresh", "reconnect", "transfer", "backup"],
            },
            LucideIconKind.FolderTree => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["files"],
                Tags = ["directory", "tree", "browser"],
            },
            LucideIconKind.FolderUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files", "arrows"],
                Tags = ["directory", "upload", "import", "export"],
            },
            LucideIconKind.FolderX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["directory", "remove", "delete"],
            },
            LucideIconKind.Folders => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["files"],
                Tags = ["multiple", "copy", "directories"],
            },
            LucideIconKind.Footprints => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["steps", "walking", "foot", "feet", "trail", "shoe"],
            },
            LucideIconKind.Forklift => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["transportation"],
                Tags = ["vehicle", "transport", "logistics"],
            },
            LucideIconKind.Forward => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "mittalyashu"],
                Categories = ["mail"],
                Tags = ["send", "share", "email"],
            },
            LucideIconKind.Frame => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Bowero", "ericfennis"],
                Categories = ["design", "photography"],
                Tags = ["logo", "design", "tool"],
            },
            LucideIconKind.Framer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["brands", "design"],
                Tags = ["logo", "design", "tool"],
            },
            LucideIconKind.Frown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["emoji", "account"],
                Tags = ["emoji", "face", "bad", "sad", "emotion"],
            },
            LucideIconKind.Fuel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "UsamaKhan"],
                Categories = ["transportation", "navigation"],
                Tags = ["filling-station", "gas", "petrol", "tank"],
            },
            LucideIconKind.Fullscreen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "multimedia", "design", "photography"],
                Tags = ["expand", "zoom", "preview", "focus", "camera", "lens", "image"],
            },
            LucideIconKind.Funnel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "lukedukeus", "jguddas", "karsa-mistmere"],
                Categories = ["layout"],
                Tags = ["filter", "hopper"],
            },
            LucideIconKind.FunnelPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["gubser", "ericfennis", "lukedukeus", "jguddas", "karsa-mistmere"],
                Categories = ["layout"],
                Tags = ["filter", "hopper", "add", "create", "new"],
            },
            LucideIconKind.FunnelX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["gubser", "ericfennis", "lukedukeus", "jguddas", "karsa-mistmere"],
                Categories = ["layout"],
                Tags = ["filter", "hopper", "remove", "delete"],
            },
            LucideIconKind.GalleryHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "photography", "multimedia"],
                Tags = ["carousel", "pictures", "images", "scroll", "swipe", "album", "portfolio"],
            },
            LucideIconKind.GalleryHorizontalEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "photography", "multimedia", "files"],
                Tags = ["carousel", "pictures", "images", "scroll", "swipe", "album", "portfolio", "history", "versions", "backup", "time machine"],
            },
            LucideIconKind.GalleryThumbnails => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "photography", "multimedia"],
                Tags = ["carousel", "pictures", "images", "album", "portfolio", "preview"],
            },
            LucideIconKind.GalleryVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "photography", "multimedia"],
                Tags = ["carousel", "pictures", "images", "scroll", "swipe", "album", "portfolio"],
            },
            LucideIconKind.GalleryVerticalEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "development", "photography", "multimedia", "files"],
                Tags = ["carousel", "pictures", "images", "scroll", "swipe", "album", "portfolio", "history", "versions", "backup", "time machine"],
            },
            LucideIconKind.Gamepad => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey"],
                Categories = ["gaming", "devices"],
                Tags = ["console"],
            },
            LucideIconKind.Gamepad2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "johnletey"],
                Categories = ["gaming", "devices"],
                Tags = ["console"],
            },
            LucideIconKind.GamepadDirectional => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["felipeajzanetti", "jguddas"],
                Categories = ["gaming", "devices"],
                Tags = ["direction", "arrow", "controller", "navigation", "button", "move", "pointer", "arrowhead", "console", "game", "gaming"],
            },
            LucideIconKind.Gauge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "Andreto", "danielbayley", "karsa-mistmere"],
                Categories = ["transportation", "sports", "science"],
                Tags = ["dashboard", "dial", "meter", "speed", "pressure", "measure", "level"],
            },
            LucideIconKind.Gavel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["navigation", "tools"],
                Tags = ["justice", "law", "court", "judgment", "legal", "hands", "penalty", "decision", "authority", "hammer", "mallet"],
            },
            LucideIconKind.Gem => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["connium", "ericfennis", "karsa-mistmere"],
                Categories = ["gaming", "development", "finance"],
                Tags = ["diamond", "crystal", "ruby", "jewellery", "price", "special", "present", "gift", "ring", "wedding", "proposal", "marriage", "rubygems"],
            },
            LucideIconKind.GeorgianLari => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kivicode"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Ghost => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["gaming"],
                Tags = ["pac-man", "spooky"],
            },
            LucideIconKind.Gift => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["gaming", "account"],
                Tags = ["present", "box", "birthday", "party"],
            },
            LucideIconKind.GitBranch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control"],
            },
            LucideIconKind.GitBranchPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["development"],
                Tags = ["add", "create", "+"],
            },
            LucideIconKind.GitCommitHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "johnletey"],
                Categories = ["development", "navigation"],
                Tags = ["code", "version control", "waypoint", "stop", "station"],
            },
            LucideIconKind.GitCommitVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "navigation"],
                Tags = ["code", "version control", "waypoint", "stop", "station"],
            },
            LucideIconKind.GitCompare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control", "diff"],
            },
            LucideIconKind.GitCompareArrows => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "arrows"],
                Tags = ["code", "version control", "diff"],
            },
            LucideIconKind.GitFork => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["development"],
                Tags = ["code", "version control"],
            },
            LucideIconKind.GitGraph => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development"],
                Tags = ["code", "version control", "commit graph", "commits", "gitlens"],
            },
            LucideIconKind.GitMerge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control"],
            },
            LucideIconKind.GitPullRequest => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control", "open"],
            },
            LucideIconKind.GitPullRequestArrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "arrows"],
                Tags = ["code", "version control", "open"],
            },
            LucideIconKind.GitPullRequestClosed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control", "rejected", "closed", "cancelled", "x"],
            },
            LucideIconKind.GitPullRequestCreate => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development"],
                Tags = ["code", "version control", "open", "plus", "add", "+"],
            },
            LucideIconKind.GitPullRequestCreateArrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "arrows"],
                Tags = ["code", "version control", "open", "plus", "add", "+"],
            },
            LucideIconKind.GitPullRequestDraft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "version control", "open", "draft", "dashed"],
            },
            LucideIconKind.Github => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["brands", "development"],
                Tags = ["logo", "version control"],
            },
            LucideIconKind.Gitlab => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["brands", "development"],
                Tags = ["logo", "version control"],
            },
            LucideIconKind.GlassWater => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["beverage", "drink", "glass", "water"],
            },
            LucideIconKind.Glasses => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis"],
                Categories = ["accessibility"],
                Tags = ["glasses", "spectacles"],
            },
            LucideIconKind.Globe => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["navigation"],
                Tags = ["world", "browser", "language", "translate"],
            },
            LucideIconKind.GlobeLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["security", "development", "devices"],
                Tags = ["vpn", "private", "privacy", "network", "world", "browser", "security", "encryption", "protection", "connection"],
            },
            LucideIconKind.Goal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["guillermo-angeles", "jguddas"],
                Categories = ["gaming"],
                Tags = ["flag", "bullseye"],
            },
            LucideIconKind.Gpu => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["xandykati98", "karsa-mistmere"],
                Categories = ["devices", "gaming"],
                Tags = ["processor", "cores", "technology", "computer", "chip", "circuit", "specs", "graphics processing unit", "video card", "display adapter", "gddr", "rendering", "digital image processing", "crypto mining"],
            },
            LucideIconKind.GraduationCap => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Tummerhore", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["buildings"],
                Tags = ["school", "university", "learn", "study", "mortarboard", "education", "ceremony", "academic", "hat", "diploma", "bachlor's", "master's", "doctorate"],
            },
            LucideIconKind.Grape => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["fruit", "wine", "food"],
            },
            LucideIconKind.Grid2x2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "layout", "design", "math"],
                Tags = ["table", "rows", "columns", "blocks", "plot", "land", "geometry", "measure", "size", "width", "height", "distance", "surface area", "square meter", "acre", "window", "skylight"],
            },
            LucideIconKind.Grid2x2Check => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "chessurisme"],
                Categories = ["text", "layout", "math"],
                Tags = ["table", "rows", "columns", "blocks", "plot", "land", "geometry", "measure", "data", "size", "width", "height", "distance", "surface area", "square meter", "acre"],
            },
            LucideIconKind.Grid2x2Plus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "chessurisme", "jguddas"],
                Categories = ["text", "layout", "math"],
                Tags = ["table", "rows", "columns", "blocks", "plot", "land", "geometry", "measure", "data", "size", "width", "height", "distance", "surface area", "square meter", "acre"],
            },
            LucideIconKind.Grid2x2X => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "chessurisme"],
                Categories = ["text", "layout", "math"],
                Tags = ["table", "rows", "columns", "data", "blocks", "plot", "land", "geometry", "measure", "size", "width", "height", "distance", "surface area", "square meter", "acre"],
            },
            LucideIconKind.Grid3x2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["qubrat"],
                Categories = ["text", "math", "layout", "design"],
                Tags = ["table", "rows", "columns", "blocks", "plot", "land", "geometry", "measure", "size", "width", "height", "distance", "surface area", "square meter", "acre", "window"],
            },
            LucideIconKind.Grid3x3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "zenoamaro", "ericfennis", "csandman", "mittalyashu"],
                Categories = ["text", "layout", "design"],
                Tags = ["table", "rows", "columns"],
            },
            LucideIconKind.Grip => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["koole", "ericfennis"],
                Categories = ["layout"],
                Tags = ["grab", "dots", "handle", "move", "drag"],
            },
            LucideIconKind.GripHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["grab", "dots", "handle", "move", "drag"],
            },
            LucideIconKind.GripVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey"],
                Categories = ["layout"],
                Tags = ["grab", "dots", "handle", "move", "drag"],
            },
            LucideIconKind.Group => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["files"],
                Tags = ["cubes", "packages", "parts", "units", "collection", "cluster", "gather", "dashed"],
            },
            LucideIconKind.Guitar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["multimedia"],
                Tags = ["acoustic", "instrument", "strings", "riff", "rock", "band", "country", "concert", "performance", "play", "lead", "loud", "music", "audio", "sound", "noise"],
            },
            LucideIconKind.Ham => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["food", "pork", "pig", "meat", "bone", "hock", "knuckle", "gammon", "cured"],
            },
            LucideIconKind.Hamburger => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "kemie", "karsa-mistmere", "jguddas", "jamiemlaw"],
                Categories = ["food-beverage"],
                Tags = ["burger", "cheeseburger", "meat", "beef", "patty", "bun", "fast food", "junk food", "takeaway", "takeout", "snack", "dish", "restaurant", "lunch", "meal", "savory", "savoury", "cookery", "cooking", "grilled", "barbecue", "barbeque", "bbq", "lettuce", "tomato", "relish", "pickles", "onions", "ketchup", "mustard", "mayonnaise"],
            },
            LucideIconKind.Hammer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere"],
                Categories = ["tools", "home"],
                Tags = ["mallet", "nails", "diy", "toolbox", "build", "construction"],
            },
            LucideIconKind.Hand => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["cursors", "accessibility"],
                Tags = ["wave", "move", "mouse", "grab"],
            },
            LucideIconKind.HandCoins => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "kayleyhill"],
                Categories = ["finance", "account"],
                Tags = ["savings", "banking", "money", "finance", "offers", "mortgage", "payment", "received", "wage", "payroll", "allowance", "pocket money", "handout", "pennies"],
            },
            LucideIconKind.HandFist => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["social", "emoji", "communication", "sports"],
                Tags = ["clench", "strength", "power", "unity", "solidarity", "rebellion", "victory", "triumph", "support", "fight", "combat", "brawl"],
            },
            LucideIconKind.HandGrab => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["cursors", "design", "layout"],
                Tags = ["hand"],
            },
            LucideIconKind.HandHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "kayleyhill", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["love", "like", "emotion"],
            },
            LucideIconKind.HandHelping => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["emoji"],
                Tags = ["agreement", "help", "proposal", "charity", "begging", "terms"],
            },
            LucideIconKind.HandMetal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["emoji", "multimedia"],
                Tags = ["rock"],
            },
            LucideIconKind.HandPlatter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage", "people"],
                Tags = ["waiter", "waitress", "restaurant", "table service", "served", "dinner", "dining", "meal", "course", "luxury"],
            },
            LucideIconKind.Handbag => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw", "karsa-mistmere"],
                Categories = ["shopping", "transportation"],
                Tags = ["bag", "baggage", "carry", "clutch", "fashion", "luggage", "purse", "tote", "travel"],
            },
            LucideIconKind.Handshake => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["account", "social", "communication", "finance", "security"],
                Tags = ["agreement", "partnership", "deal", "business", "assistance", "cooperation", "friendship", "union", "terms"],
            },
            LucideIconKind.HardDrive => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["development", "devices"],
                Tags = ["computer", "server", "memory", "data", "ssd", "disk", "hard disk"],
            },
            LucideIconKind.HardDriveDownload => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "devices", "arrows", "files"],
                Tags = ["computer", "server", "memory", "data", "ssd", "disk", "hard disk", "save"],
            },
            LucideIconKind.HardDriveUpload => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "devices", "arrows", "files"],
                Tags = ["computer", "server", "memory", "data", "ssd", "disk", "hard disk", "save"],
            },
            LucideIconKind.HardHat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis"],
                Categories = ["tools"],
                Tags = ["helmet", "construction", "safety", "savety"],
            },
            LucideIconKind.Hash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["text", "social"],
                Tags = ["hashtag", "number", "pound"],
            },
            LucideIconKind.HatGlasses => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["social", "account", "security"],
                Tags = ["incognito", "disguise", "costume", "masked", "anonymous", "anonymity", "privacy", "private browsing", "stealth", "hidden", "undercover", "cloak", "invisible", "ghost", "spy", "agent", "detective", "identity", "cap", "fedora", "spectacles", "shades", "sunglasses", "eyewear"],
            },
            LucideIconKind.Haze => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["weather"],
                Tags = ["mist", "fog"],
            },
            LucideIconKind.HdmiPort => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "multimedia", "gaming"],
                Tags = ["socket", "plug", "slot", "controller", "connector", "interface", "console", "signal", "audio", "video", "visual", "av", "data", "input", "output"],
            },
            LucideIconKind.Heading => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["h1", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["h1", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["h2", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["text"],
                Tags = ["h3", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["text"],
                Tags = ["h4", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading5 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["text"],
                Tags = ["h5", "html", "markup", "markdown"],
            },
            LucideIconKind.Heading6 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["h6", "html", "markup", "markdown"],
            },
            LucideIconKind.HeadphoneOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas", "Need-an-AwP"],
                Categories = ["multimedia", "connectivity", "communication", "devices", "gaming"],
                Tags = ["music", "audio", "sound", "mute", "off"],
            },
            LucideIconKind.Headphones => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["multimedia", "connectivity", "devices", "files", "gaming"],
                Tags = ["music", "audio", "sound"],
            },
            LucideIconKind.Headset => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["multimedia", "connectivity", "devices", "files", "gaming"],
                Tags = ["music", "audio", "sound", "gaming", "headphones", "headset", "call", "center", "phone", "telephone", "voip", "video"],
            },
            LucideIconKind.Heart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["medical", "social", "multimedia", "emoji", "gaming", "shapes"],
                Tags = ["like", "love", "emotion", "suit", "playing", "cards"],
            },
            LucideIconKind.HeartCrack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["emoji"],
                Tags = ["heartbreak", "sadness", "emotion"],
            },
            LucideIconKind.HeartHandshake => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["emoji", "account", "security"],
                Tags = ["agreement", "charity", "help", "deal", "terms", "emotion", "together", "handshake"],
            },
            LucideIconKind.HeartMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "karsa-mistmere", "Ayberkyvs", "jguddas"],
                Categories = ["medical", "account", "multimedia", "gaming", "social"],
                Tags = ["unlike", "unfavorite", "remove", "damage", "ui & ux"],
            },
            LucideIconKind.HeartOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley", "jguddas"],
                Categories = ["social", "multimedia"],
                Tags = ["unlike", "dislike", "hate", "emotion"],
            },
            LucideIconKind.HeartPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "karsa-mistmere", "jguddas", "Ayberkyvs", "UsamaKhan"],
                Categories = ["medical", "account", "multimedia", "gaming", "social"],
                Tags = ["plus", "like", "favorite", "add", "health", "support"],
            },
            LucideIconKind.HeartPulse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["medical"],
                Tags = ["heartbeat", "pulse", "health", "medical", "blood pressure", "cardiac", "systole", "diastole"],
            },
            LucideIconKind.Heater => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["home", "devices", "travel"],
                Tags = ["heating", "warmth", "comfort", "fire", "stove", "electric", "electronics", "amenities"],
            },
            LucideIconKind.Hexagon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["shapes", "brands", "development"],
                Tags = ["shape", "node.js", "logo"],
            },
            LucideIconKind.Highlighter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "Andreto", "ericfennis"],
                Categories = ["text", "design"],
                Tags = ["mark", "text"],
            },
            LucideIconKind.History => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows", "time"],
                Tags = ["time", "redo", "undo", "rewind", "timeline", "version", "time machine", "backup", "rotate", "ccw"],
            },
            LucideIconKind.Hop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["beer", "brewery", "drink"],
            },
            LucideIconKind.HopOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["beer", "brewery", "drink", "hop free", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.Hospital => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["medical", "buildings", "navigation", "travel"],
                Tags = ["infirmary", "sanatorium", "healthcare", "doctor", "hospice", "clinic", "emergency room", "ward", "building", "medical", "vet"],
            },
            LucideIconKind.Hotel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["buildings", "navigation", "travel"],
                Tags = ["building", "hostel", "motel", "inn"],
            },
            LucideIconKind.Hourglass => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["time", "gaming"],
                Tags = ["timer", "time", "sandglass"],
            },
            LucideIconKind.House => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "karsa-mistmere"],
                Categories = ["buildings", "home"],
                Tags = ["home", "living", "building", "residence", "architecture"],
            },
            LucideIconKind.HouseHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["home", "buildings", "medical"],
                Tags = ["home sweet home", "abode", "building", "residence", "healthy living", "lifestyle"],
            },
            LucideIconKind.HousePlug => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "karsa-mistmere"],
                Categories = ["buildings", "home", "sustainability"],
                Tags = ["home", "living", "building", "residence", "architecture", "autarky", "energy"],
            },
            LucideIconKind.HousePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["buildings", "medical"],
                Tags = ["home", "living", "medical", "new", "addition", "building", "residence", "architecture"],
            },
            LucideIconKind.HouseWifi => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["akshaymemane", "jguddas", "karsa-mistmere"],
                Categories = ["home", "buildings", "connectivity"],
                Tags = ["home", "living", "building", "wifi", "connectivity"],
            },
            LucideIconKind.IceCreamBowl => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie", "jguddas", "karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["gelato", "food", "dessert", "dish", "restaurant", "course", "meal"],
            },
            LucideIconKind.IceCreamCone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["gelato", "food"],
            },
            LucideIconKind.IdCard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "karsa-mistmere"],
                Categories = ["security", "account"],
                Tags = ["card", "badge", "identity", "authentication", "secure"],
            },
            LucideIconKind.IdCardLanyard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["python2911", "UsamaKhan", "jguddas"],
                Categories = ["security", "account"],
                Tags = ["id-card", "id-card-lanyard", "identity", "employee", "gate-pass", "badge"],
            },
            LucideIconKind.Image => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["photography", "text", "multimedia", "files"],
                Tags = ["picture", "photo"],
            },
            LucideIconKind.ImageDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["photography", "text", "multimedia", "files"],
                Tags = ["picture", "photo", "download", "save", "export"],
            },
            LucideIconKind.ImageMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["photography", "multimedia", "files"],
                Tags = ["remove", "delete"],
            },
            LucideIconKind.ImageOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["photography", "multimedia", "files"],
                Tags = ["picture", "photo"],
            },
            LucideIconKind.ImagePlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["photography", "text", "multimedia", "files"],
                Tags = ["picture", "gif", "photo"],
            },
            LucideIconKind.ImagePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["photography", "multimedia", "files"],
                Tags = ["add", "create", "picture"],
            },
            LucideIconKind.ImageUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["photography", "text", "multimedia", "files"],
                Tags = ["picture", "photo", "upload", "import"],
            },
            LucideIconKind.ImageUpscale => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["llaenowyd", "mishkaio", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["photography", "multimedia"],
                Tags = ["resize", "picture", "sharpen", "increase"],
            },
            LucideIconKind.Images => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["photography", "text", "multimedia", "files"],
                Tags = ["picture", "photo", "multiple", "copy", "gallery", "album", "collection", "slideshow", "showcase"],
            },
            LucideIconKind.Import => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["arrows", "files"],
                Tags = ["save"],
            },
            LucideIconKind.Inbox => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["account", "mail"],
                Tags = ["email"],
            },
            LucideIconKind.IndianRupee => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Infinity => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["multimedia"],
                Tags = ["unlimited", "forever", "loop", "math"],
            },
            LucideIconKind.Info => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["accessibility", "notifications"],
                Tags = ["help"],
            },
            LucideIconKind.InspectionPanel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["tools"],
                Tags = ["access", "cover", "tile", "metal", "materials", "screws"],
            },
            LucideIconKind.Instagram => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["brands", "social", "photography"],
                Tags = ["logo", "camera", "social"],
            },
            LucideIconKind.Italic => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["text"],
                Tags = ["oblique", "text", "format"],
            },
            LucideIconKind.IterationCcw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["arrows", "design"],
                Tags = ["arrow", "right"],
            },
            LucideIconKind.IterationCw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["arrows", "design"],
                Tags = ["arrow", "left"],
            },
            LucideIconKind.JapaneseYen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Joystick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "karsa-mistmere", "ericfennis"],
                Categories = ["gaming", "devices"],
                Tags = ["game", "console", "control stick"],
            },
            LucideIconKind.Kanban => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["charts", "development", "design"],
                Tags = ["projects", "manage", "overview", "board", "tickets", "issues", "roadmap", "plan", "intentions", "productivity", "work", "agile", "code", "coding"],
            },
            LucideIconKind.Kayak => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "jpjacobpadilla"],
                Categories = ["transportation"],
                Tags = ["kayak", "boat", "paddle", "water", "sport", "recreation", "adventure", "outdoors", "equipment", "lake", "ocean"],
            },
            LucideIconKind.Key => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ashygee", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["security", "account"],
                Tags = ["password", "login", "authentication", "secure", "unlock", "keychain", "key ring", "fob"],
            },
            LucideIconKind.KeyRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["security", "account"],
                Tags = ["password", "login", "authentication", "secure", "unlock"],
            },
            LucideIconKind.KeySquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["security", "account"],
                Tags = ["password", "login", "authentication", "secure", "unlock", "car key"],
            },
            LucideIconKind.Keyboard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "ericfennis"],
                Categories = ["text", "devices", "development"],
                Tags = ["layout", "spell", "settings", "mouse"],
            },
            LucideIconKind.KeyboardMusic => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "devices"],
                Tags = ["music", "audio", "sound", "noise", "notes", "keys", "chord", "octave", "midi", "controller", "instrument", "electric", "signal", "digital", "studio", "production", "producer", "pianist", "piano", "play", "performance", "concert"],
            },
            LucideIconKind.KeyboardOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Diottodev", "karsa-mistmere"],
                Categories = ["devices", "text", "development"],
                Tags = ["unkeys", "layout", "spell", "settings", "mouse"],
            },
            LucideIconKind.Lamp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["home"],
                Tags = ["lighting", "household", "home", "furniture"],
            },
            LucideIconKind.LampCeiling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jamiemlaw"],
                Categories = ["home"],
                Tags = ["lighting", "household", "home", "furniture"],
            },
            LucideIconKind.LampDesk => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "jamiemlaw"],
                Categories = ["home"],
                Tags = ["lighting", "household", "office", "desk", "home", "furniture"],
            },
            LucideIconKind.LampFloor => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jamiemlaw"],
                Categories = ["home"],
                Tags = ["lighting", "household", "floor", "home", "furniture"],
            },
            LucideIconKind.LampWallDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["home"],
                Tags = ["lighting", "household", "wall", "home", "furniture"],
            },
            LucideIconKind.LampWallUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["home"],
                Tags = ["lighting", "household", "wall", "home", "furniture"],
            },
            LucideIconKind.LandPlot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["design", "tools", "math", "sports", "gaming"],
                Tags = ["area", "surface", "square metres", "allotment", "parcel", "property", "plane", "acres", "measure", "distance", "isometric", "flag", "golf course", "hole"],
            },
            LucideIconKind.Landmark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["connium", "ericfennis", "karsa-mistmere"],
                Categories = ["finance", "navigation", "buildings"],
                Tags = ["bank", "building", "capitol", "finance", "money", "museum", "art gallery", "hall", "institute", "pediment", "portico", "columns", "pillars", "classical", "architecture", "government", "institution"],
            },
            LucideIconKind.Languages => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu", "johnletey"],
                Categories = ["text"],
                Tags = ["translate"],
            },
            LucideIconKind.Laptop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["devices"],
                Tags = ["computer", "screen", "remote"],
            },
            LucideIconKind.LaptopMinimal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["devices"],
                Tags = ["computer", "screen", "remote"],
            },
            LucideIconKind.LaptopMinimalCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["devices", "notifications"],
                Tags = ["computer", "screen", "remote", "success", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.Lasso => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mishkaio", "ericfennis", "csandman", "jguddas"],
                Categories = ["design", "cursors"],
                Tags = ["select", "cursor"],
            },
            LucideIconKind.LassoSelect => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mishkaio", "ericfennis", "csandman"],
                Categories = ["arrows", "design", "cursors"],
                Tags = ["select", "cursor"],
            },
            LucideIconKind.Laugh => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["emoji"],
                Tags = ["emoji", "face", "happy", "good", "emotion"],
            },
            LucideIconKind.Layers => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "danielbayley", "jguddas"],
                Categories = ["design", "layout"],
                Tags = ["stack", "pile", "pages", "sheets", "paperwork", "copies", "copy"],
            },
            LucideIconKind.Layers2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["design", "layout"],
                Tags = ["stack", "pile", "pages", "sheets", "paperwork", "copies", "copy", "duplicate", "double", "shortcuts"],
            },
            LucideIconKind.LayoutDashboard => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["design", "layout"],
                Tags = ["masonry", "brick"],
            },
            LucideIconKind.LayoutGrid => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zenoamaro", "ericfennis", "csandman", "mittalyashu", "danielbayley"],
                Categories = ["design", "layout"],
                Tags = ["app", "home", "start"],
            },
            LucideIconKind.LayoutList => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["design", "layout", "photography", "text"],
                Tags = ["todo", "tasks", "items", "pending", "image", "photo"],
            },
            LucideIconKind.LayoutPanelLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["design", "layout"],
                Tags = ["app", "home", "start", "grid"],
            },
            LucideIconKind.LayoutPanelTop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout"],
                Tags = ["window", "webpage", "block", "section", "grid", "template", "structure"],
            },
            LucideIconKind.LayoutTemplate => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley"],
                Categories = ["layout"],
                Tags = ["window", "webpage", "block", "section"],
            },
            LucideIconKind.Leaf => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["nature", "sustainability", "seasons"],
                Tags = ["sustainability", "nature", "energy", "plant", "autumn"],
            },
            LucideIconKind.LeafyGreen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage", "emoji", "sustainability"],
                Tags = ["salad", "lettuce", "vegetable", "chard", "cabbage", "bok choy"],
            },
            LucideIconKind.Lectern => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["gurtt", "karsa-mistmere"],
                Categories = ["communication", "multimedia"],
                Tags = ["pulpit", "podium", "stand"],
            },
            LucideIconKind.Library => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["johnletey", "csandman", "ericfennis"],
                Categories = ["text", "photography", "multimedia", "navigation", "development"],
                Tags = ["books", "reading", "written", "authors", "stories", "fiction", "novels", "information", "knowledge", "education", "high school", "university", "college", "academy", "learning", "study", "research", "collection", "vinyl", "records", "albums", "music", "package"],
            },
            LucideIconKind.LibraryBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "photography", "multimedia", "navigation", "development"],
                Tags = ["books", "reading", "written", "authors", "stories", "fiction", "novels", "information", "knowledge", "education", "high school", "university", "college", "academy", "learning", "study", "research", "collection", "vinyl", "records", "albums", "music", "package"],
            },
            LucideIconKind.LifeBuoy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "karsa-mistmere"],
                Categories = ["accessibility", "medical"],
                Tags = ["preserver", "life belt", "lifesaver", "help", "rescue", "ship", "ring", "raft", "inflatable", "wheel", "donut"],
            },
            LucideIconKind.Ligature => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text"],
                Tags = ["text", "font", "typography", "alternates", "alternatives"],
            },
            LucideIconKind.Lightbulb => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley"],
                Categories = ["photography"],
                Tags = ["idea", "bright", "lights"],
            },
            LucideIconKind.LightbulbOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere", "danielbayley"],
                Categories = ["photography"],
                Tags = ["lights"],
            },
            LucideIconKind.LineSquiggle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme", "jguddas"],
                Categories = ["shapes", "math", "design"],
                Tags = ["line", "snakes", "annotate", "curve", "doodle", "stroke", "pen", "tool", "gesture", "draw", "wave", "art", "road"],
            },
            LucideIconKind.Link => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["text", "account"],
                Tags = ["chain", "url"],
            },
            LucideIconKind.Link2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "johnletey"],
                Categories = ["text", "account"],
                Tags = ["chain", "url"],
            },
            LucideIconKind.Link2Off => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["unchain", "chain"],
            },
            LucideIconKind.Linkedin => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["okcoker", "csandman", "ericfennis"],
                Categories = ["social", "brands"],
                Tags = ["logo", "social media", "social"],
            },
            LucideIconKind.List => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["options"],
            },
            LucideIconKind.ListCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["guanboo-yang", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["done", "check", "tick", "complete", "list", "to-do", "bom"],
            },
            LucideIconKind.ListChecks => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["todo", "done", "check", "tick", "complete", "tasks", "items", "pending"],
            },
            LucideIconKind.ListChevronsDownUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "ocavue", "jguddas", "PeterlitsZo", "mittalyashu", "juliankellydesign", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["options", "items", "collapse", "expand", "details", "disclosure", "show", "hide", "toggle", "accordion", "more", "less", "fold", "unfold", "vertical"],
            },
            LucideIconKind.ListChevronsUpDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "ocavue", "jguddas", "PeterlitsZo", "mittalyashu", "juliankellydesign", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["options", "items", "collapse", "expand", "details", "disclosure", "show", "hide", "toggle", "accordion", "more", "less", "fold", "unfold", "vertical"],
            },
            LucideIconKind.ListCollapse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ocavue", "jguddas", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["items", "collapse", "expand", "details", "disclosure", "show", "hide", "toggle", "accordion", "more", "less", "fold", "unfold"],
            },
            LucideIconKind.ListEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["queue", "bottom", "end", "playlist"],
            },
            LucideIconKind.ListFilter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["options"],
            },
            LucideIconKind.ListFilterPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["abdeniz", "karsa-mistmere"],
                Categories = ["text", "layout"],
                Tags = ["filter", "plus", "options", "add"],
            },
            LucideIconKind.ListIndentDecrease => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Themistoklis", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["text", "tab"],
            },
            LucideIconKind.ListIndentIncrease => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Themistoklis", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "development"],
                Tags = ["text", "tab"],
            },
            LucideIconKind.ListMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["playlist", "remove", "song", "subtract", "delete", "unqueue"],
            },
            LucideIconKind.ListMusic => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["playlist", "queue", "music", "audio", "playback"],
            },
            LucideIconKind.ListOrdered => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["number", "order", "queue"],
            },
            LucideIconKind.ListPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["playlist", "add", "song", "track", "new"],
            },
            LucideIconKind.ListRestart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["reset", "refresh", "reload", "playlist", "replay"],
            },
            LucideIconKind.ListStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["queue", "top", "start", "next", "playlist"],
            },
            LucideIconKind.ListTodo => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["text"],
                Tags = ["todo", "done", "check", "tick", "complete", "tasks", "items", "pending"],
            },
            LucideIconKind.ListTree => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["files", "text", "layout"],
                Tags = ["tree", "browser"],
            },
            LucideIconKind.ListVideo => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["playlist", "video", "playback"],
            },
            LucideIconKind.ListX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["multimedia", "text"],
                Tags = ["playlist", "subtract", "remove", "delete", "unqueue"],
            },
            LucideIconKind.Loader => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["cursors", "multimedia", "layout", "design"],
                Tags = ["loading", "wait", "busy", "progress", "spinner", "spinning", "throbber"],
            },
            LucideIconKind.LoaderCircle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["cursors", "multimedia", "layout"],
                Tags = ["loading", "wait", "busy", "progress", "spinner", "spinning", "throbber", "circle"],
            },
            LucideIconKind.LoaderPinwheel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["cursors", "design"],
                Tags = ["loading", "wait", "busy", "progress", "throbber", "spinner", "spinning", "beach ball", "frozen", "freeze"],
            },
            LucideIconKind.Locate => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["map", "gps", "location", "cross"],
            },
            LucideIconKind.LocateFixed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "danielbayley", "jguddas", "ericfennis"],
                Categories = ["navigation"],
                Tags = ["map", "gps", "location", "cross"],
            },
            LucideIconKind.LocateOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["fdev", "jamiemlaw"],
                Categories = ["navigation"],
                Tags = ["map", "gps", "location", "cross"],
            },
            LucideIconKind.Lock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["security"],
                Tags = ["security", "password", "secure", "admin"],
            },
            LucideIconKind.LockKeyhole => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "cd16b", "danielbayley", "karsa-mistmere"],
                Categories = ["security"],
                Tags = ["security", "password", "secure", "admin"],
            },
            LucideIconKind.LockKeyholeOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "cd16b", "danielbayley", "karsa-mistmere"],
                Categories = ["security"],
                Tags = ["security"],
            },
            LucideIconKind.LockOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["security"],
                Tags = ["security"],
            },
            LucideIconKind.LogIn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "account"],
                Tags = ["sign in", "arrow", "enter", "auth"],
            },
            LucideIconKind.LogOut => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "account"],
                Tags = ["sign out", "arrow", "exit", "auth"],
            },
            LucideIconKind.Logs => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["options", "list", "menu", "order", "queue", "tasks", "logs"],
            },
            LucideIconKind.Lollipop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage"],
                Tags = ["lolly", "candy", "sugar", "food", "sweet", "dessert", "spiral"],
            },
            LucideIconKind.Luggage => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["travel", "transportation"],
                Tags = ["baggage", "luggage", "travel", "suitcase"],
            },
            LucideIconKind.Magnet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["design"],
                Tags = ["horseshoe", "lock", "science", "snap"],
            },
            LucideIconKind.Mail => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["text", "account", "mail"],
                Tags = ["email", "message", "letter", "unread"],
            },
            LucideIconKind.MailCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "subscribe", "delivered", "success", "read", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.MailMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "remove", "delete"],
            },
            LucideIconKind.MailOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "read"],
            },
            LucideIconKind.MailPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "add", "create", "new", "compose"],
            },
            LucideIconKind.MailQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "delivery", "undelivered"],
            },
            LucideIconKind.MailSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "search", "lens"],
            },
            LucideIconKind.MailWarning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "delivery error", "exclamation mark"],
            },
            LucideIconKind.MailX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["mail"],
                Tags = ["email", "message", "letter", "remove", "delete"],
            },
            LucideIconKind.Mailbox => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["mail"],
                Tags = ["emails", "messages", "letters", "mailing list", "newsletter"],
            },
            LucideIconKind.Mails => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["mail"],
                Tags = ["emails", "messages", "letters", "multiple", "mailing list", "newsletter", "copy"],
            },
            LucideIconKind.Map => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["text", "navigation"],
                Tags = ["location", "navigation", "travel"],
            },
            LucideIconKind.MapMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "MarianoFranzese", "jguddas"],
                Categories = ["navigation", "travel"],
                Tags = ["location", "navigation", "travel", "drop", "delete", "remove", "erase"],
            },
            LucideIconKind.MapPin => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop"],
            },
            LucideIconKind.MapPinCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "done", "tick", "complete", "task", "added"],
            },
            LucideIconKind.MapPinCheckInside => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "done", "tick", "complete", "task", "added"],
            },
            LucideIconKind.MapPinHouse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "home", "living", "building", "residence", "architecture", "address", "poi", "real estate", "property", "navigation", "destination", "geolocation", "place", "landmark"],
            },
            LucideIconKind.MapPinMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "delete", "remove", "erase"],
            },
            LucideIconKind.MapPinMinusInside => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "delete", "remove", "erase"],
            },
            LucideIconKind.MapPinOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["navigation", "travel"],
                Tags = ["location", "waypoint", "marker", "remove"],
            },
            LucideIconKind.MapPinPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "sachinkr7368"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "edit"],
            },
            LucideIconKind.MapPinPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "add", "create", "new"],
            },
            LucideIconKind.MapPinPlusInside => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "add", "create", "new"],
            },
            LucideIconKind.MapPinX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "delete", "remove", "erase"],
            },
            LucideIconKind.MapPinXInside => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop", "delete", "remove", "erase"],
            },
            LucideIconKind.MapPinned => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["navigation", "travel", "account"],
                Tags = ["location", "waypoint", "marker", "drop"],
            },
            LucideIconKind.MapPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "Seanw265"],
                Categories = ["navigation"],
                Tags = ["location", "navigation", "travel", "new", "add", "create"],
            },
            LucideIconKind.Mars => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "jamiemlaw"],
                Categories = ["medical"],
                Tags = ["gender", "sex", "male", "masculine", "man", "boy"],
            },
            LucideIconKind.MarsStroke => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["medical"],
                Tags = ["gender", "androgyne", "transgender"],
            },
            LucideIconKind.Martini => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["food-beverage"],
                Tags = ["cocktail", "alcohol", "beverage", "bar", "drink", "glass"],
            },
            LucideIconKind.Maximize => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["layout", "design"],
                Tags = ["fullscreen", "expand", "dashed"],
            },
            LucideIconKind.Maximize2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "layout", "design"],
                Tags = ["fullscreen", "arrows", "expand"],
            },
            LucideIconKind.Medal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["sports", "gaming"],
                Tags = ["prize", "sports", "winner", "trophy", "award", "achievement"],
            },
            LucideIconKind.Megaphone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["multimedia", "notifications"],
                Tags = ["advertisement", "announcement", "attention", "alert", "loudspeaker", "megaphone", "notification"],
            },
            LucideIconKind.MegaphoneOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["multimedia", "notifications"],
                Tags = ["advertisement", "announcement", "attention", "alert", "loudspeaker", "megaphone", "notification", "disable", "silent"],
            },
            LucideIconKind.Meh => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["emoji"],
                Tags = ["emoji", "face", "neutral", "emotion"],
            },
            LucideIconKind.MemoryStick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["devices", "gaming"],
                Tags = ["ram", "random access", "technology", "computer", "chip", "circuit", "specs", "capacity", "gigabytes", "gb"],
            },
            LucideIconKind.Menu => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["layout", "account"],
                Tags = ["bars", "navigation", "hamburger", "options"],
            },
            LucideIconKind.Merge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["development", "arrows"],
                Tags = ["combine", "join", "unite"],
            },
            LucideIconKind.MessageCircle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble"],
            },
            LucideIconKind.MessageCircleCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["development", "social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "code review", "coding"],
            },
            LucideIconKind.MessageCircleDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "draft"],
            },
            LucideIconKind.MessageCircleHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "positive", "like", "love", "interest", "valentine", "dating", "date", "speech bubble"],
            },
            LucideIconKind.MessageCircleMore => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "typing", "writing", "responding", "ellipsis", "etc", "et cetera", "...", "…"],
            },
            LucideIconKind.MessageCircleOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "clear", "close", "delete", "remove", "cancel", "silence", "mute", "moderate"],
            },
            LucideIconKind.MessageCirclePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "add"],
            },
            LucideIconKind.MessageCircleQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "help"],
            },
            LucideIconKind.MessageCircleReply => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "reply", "response"],
            },
            LucideIconKind.MessageCircleWarning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social", "notifications"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "report", "abuse", "offense", "alert", "danger", "caution", "protected", "exclamation mark"],
            },
            LucideIconKind.MessageCircleX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["account", "social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "clear", "close", "delete", "remove", "cancel", "silence", "mute", "moderate"],
            },
            LucideIconKind.MessageSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble"],
            },
            LucideIconKind.MessageSquareCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["development", "social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "code review", "coding"],
            },
            LucideIconKind.MessageSquareDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "draft"],
            },
            LucideIconKind.MessageSquareDiff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["development", "files", "social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "add", "patch", "difference", "plus", "minus", "plus-minus", "math", "code review", "coding", "version control", "git"],
            },
            LucideIconKind.MessageSquareDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social", "notifications"],
                Tags = ["unread", "unresolved", "comment", "chat", "conversation", "dialog", "feedback", "speech bubble"],
            },
            LucideIconKind.MessageSquareHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "positive", "like", "love", "interest", "valentine", "dating", "date", "speech bubble"],
            },
            LucideIconKind.MessageSquareLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "secure", "encrypted"],
            },
            LucideIconKind.MessageSquareMore => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "typing", "writing", "responding", "ellipsis", "etc", "et cetera", "...", "…"],
            },
            LucideIconKind.MessageSquareOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "clear", "close", "delete", "remove", "cancel", "silence", "mute", "moderate"],
            },
            LucideIconKind.MessageSquarePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "add"],
            },
            LucideIconKind.MessageSquareQuote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["social", "text"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "blockquote", "quotation", "indent", "reply", "response"],
            },
            LucideIconKind.MessageSquareReply => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "reply", "response"],
            },
            LucideIconKind.MessageSquareShare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "network", "forward"],
            },
            LucideIconKind.MessageSquareText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble"],
            },
            LucideIconKind.MessageSquareWarning => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social", "notifications"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "report", "abuse", "offense", "alert", "danger", "caution", "protected", "exclamation mark"],
            },
            LucideIconKind.MessageSquareX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubble", "clear", "close", "delete", "remove", "cancel", "silence", "mute", "moderate"],
            },
            LucideIconKind.MessagesSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["comment", "chat", "conversation", "dialog", "feedback", "speech bubbles", "copy", "multiple", "discussion", "interview", "debate"],
            },
            LucideIconKind.Mic => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["devices", "communication", "connectivity", "multimedia"],
                Tags = ["record", "sound", "listen", "radio", "podcast", "microphone"],
            },
            LucideIconKind.MicOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "LieOnLion"],
                Categories = ["devices", "communication", "connectivity", "multimedia"],
                Tags = ["record", "sound", "mute", "microphone"],
            },
            LucideIconKind.MicVocal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas"],
                Categories = ["devices", "multimedia"],
                Tags = ["lyrics", "voice", "listen", "sound", "music", "radio", "podcast", "karaoke", "singing", "microphone"],
            },
            LucideIconKind.Microchip => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "ericfennis"],
                Categories = ["devices"],
                Tags = ["processor", "cores", "technology", "computer", "chip", "integrated circuit", "memory", "ram", "specs", "gpu", "gigahertz", "ghz"],
            },
            LucideIconKind.Microscope => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["science", "medical"],
                Tags = ["medical", "education", "science", "imaging", "research"],
            },
            LucideIconKind.Microwave => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage", "home"],
                Tags = ["oven", "cooker", "toaster oven", "bake"],
            },
            LucideIconKind.Milestone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["arrows", "navigation", "development", "gaming"],
                Tags = ["signpost", "direction", "right", "east", "forward", "version control", "waypoint"],
            },
            LucideIconKind.Milk => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["lactose", "bottle", "beverage", "drink", "water", "diet"],
            },
            LucideIconKind.MilkOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["lactose free", "bottle", "beverage", "drink", "water", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.Minimize => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["layout", "design"],
                Tags = ["exit fullscreen", "close", "shrink"],
            },
            LucideIconKind.Minimize2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "layout", "design"],
                Tags = ["exit fullscreen", "arrows", "close", "shrink"],
            },
            LucideIconKind.Minus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "development", "text", "tools"],
                Tags = ["subtract", "remove", "decrease", "decrement", "reduce", "negative", "calculate", "line", "divider", "separator", "horizontal rule", "hr", "html", "markup", "markdown", "---", "toolbar", "operator", "code", "coding", "minimum", "downgrade"],
            },
            LucideIconKind.Monitor => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "desktop", "running", "active", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorCloud => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "development"],
                Tags = ["virtual machine", "virtual desktop", "vm", "vdi", "computing", "remote work", "monitoring", "infrastructure", "software as a service", "saas", "workstation", "environment", "tv", "screen", "display"],
            },
            LucideIconKind.MonitorCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "UsamaKhan"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "virtual machine", "vm", "executable", "settings", "cog", "edit", "gear", "configuration", "preferences", "system", "control panel", "network", "computing"],
            },
            LucideIconKind.MonitorDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "desktop", "running", "active", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "desktop", "download"],
            },
            LucideIconKind.MonitorOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["yukosgiti", "ericfennis", "csandman"],
                Categories = ["connectivity", "devices"],
                Tags = ["share"],
            },
            LucideIconKind.MonitorPause => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "multimedia"],
                Tags = ["tv", "screen", "display", "desktop", "video", "movie", "film", "suspend", "hibernate", "boot", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorPlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "multimedia"],
                Tags = ["tv", "screen", "display", "desktop", "video", "movie", "film", "running", "start", "boot", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorSmartphone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["badraxas", "karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["connectivity", "devices"],
                Tags = ["smartphone", "phone", "cellphone", "device", "mobile", "desktop", "monitor", "responsive", "screens"],
            },
            LucideIconKind.MonitorSpeaker => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["connectivity", "devices"],
                Tags = ["devices", "connect", "cast"],
            },
            LucideIconKind.MonitorStop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "multimedia"],
                Tags = ["tv", "screen", "display", "desktop", "video", "movie", "film", "stop", "shutdown", "virtual machine", "vm"],
            },
            LucideIconKind.MonitorUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "upload", "connect", "remote", "screen share"],
            },
            LucideIconKind.MonitorX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["connectivity", "devices"],
                Tags = ["tv", "screen", "display", "desktop", "virtual machine", "vm", "close", "stop", "suspend", "remove", "delete"],
            },
            LucideIconKind.Moon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["accessibility"],
                Tags = ["dark", "night"],
            },
            LucideIconKind.MoonStar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["accessibility", "weather"],
                Tags = ["dark", "night", "star"],
            },
            LucideIconKind.Motorbike => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["transportation"],
                Tags = ["moto", "motorcycle", "transport", "vehicle", "drive", "ride", "trip", "race", "racing", "journey", "delivery"],
            },
            LucideIconKind.Mountain => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kerkeslager", "ericfennis", "danielbayley", "karsa-mistmere"],
                Categories = ["nature", "gaming"],
                Tags = ["climb", "hike", "rock"],
            },
            LucideIconKind.MountainSnow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kerkeslager", "ericfennis"],
                Categories = ["nature"],
                Tags = ["alpine", "climb", "snow"],
            },
            LucideIconKind.Mouse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["devices"],
                Tags = ["device", "scroll", "click"],
            },
            LucideIconKind.MouseOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "mittalyashu", "ericfennis"],
                Categories = ["devices"],
                Tags = ["device", "scroll", "click", "disabled"],
            },
            LucideIconKind.MousePointer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ashygee", "ericfennis"],
                Categories = ["arrows", "cursors"],
                Tags = ["click", "select"],
            },
            LucideIconKind.MousePointer2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["arrows", "cursors"],
                Tags = ["click", "select"],
            },
            LucideIconKind.MousePointerBan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "cursors"],
                Tags = ["wait", "busy", "loading", "blocked", "frozen", "freeze"],
            },
            LucideIconKind.MousePointerClick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas"],
                Categories = ["arrows", "cursors"],
                Tags = ["click", "select"],
            },
            LucideIconKind.Move => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["arrows", "cursors"],
                Tags = ["arrows"],
            },
            LucideIconKind.Move3d => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "ericfennis"],
                Categories = ["design"],
                Tags = ["arrows", "axis", "gizmo", "coordinates", "transform", "translate"],
            },
            LucideIconKind.MoveDiagonal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["arrows", "cursors"],
                Tags = ["double", "arrow"],
            },
            LucideIconKind.MoveDiagonal2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["arrows", "cursors"],
                Tags = ["double", "arrow"],
            },
            LucideIconKind.MoveDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction", "downwards", "south"],
            },
            LucideIconKind.MoveDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["siarie", "ericfennis", "karsa-mistmere", "jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction"],
            },
            LucideIconKind.MoveDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction"],
            },
            LucideIconKind.MoveHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["arrows", "cursors"],
                Tags = ["double", "arrow"],
            },
            LucideIconKind.MoveLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction", "back", "west"],
            },
            LucideIconKind.MoveRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction", "trend flat", "east"],
            },
            LucideIconKind.MoveUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction", "upwards", "north"],
            },
            LucideIconKind.MoveUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction"],
            },
            LucideIconKind.MoveUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jonas-hoebenreich"],
                Categories = ["arrows"],
                Tags = ["arrow", "direction"],
            },
            LucideIconKind.MoveVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["arrows", "cursors"],
                Tags = ["double", "arrow"],
            },
            LucideIconKind.Music => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["multimedia", "files"],
                Tags = ["note", "quaver", "eighth note"],
            },
            LucideIconKind.Music2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "files"],
                Tags = ["quaver", "eighth note", "note"],
            },
            LucideIconKind.Music3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "files"],
                Tags = ["crotchet", "minim", "quarter note", "half note", "note"],
            },
            LucideIconKind.Music4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["it-is-not", "karsa-mistmere"],
                Categories = ["multimedia", "files"],
                Tags = ["semiquaver", "sixteenth note", "note"],
            },
            LucideIconKind.Navigation => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["navigation"],
                Tags = ["location", "travel"],
            },
            LucideIconKind.Navigation2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["navigation"],
                Tags = ["location", "travel"],
            },
            LucideIconKind.Navigation2Off => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["navigation"],
                Tags = ["location", "travel"],
            },
            LucideIconKind.NavigationOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["navigation"],
                Tags = ["location", "travel"],
            },
            LucideIconKind.Network => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "csandman", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["tree"],
            },
            LucideIconKind.Newspaper => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["multimedia", "communication"],
                Tags = ["news", "feed", "home", "magazine", "article", "headline"],
            },
            LucideIconKind.Nfc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["communication", "finance", "devices"],
                Tags = ["contactless", "payment", "near-field communication"],
            },
            LucideIconKind.NonBinary => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["medical"],
                Tags = ["gender", "nonbinary", "enby"],
            },
            LucideIconKind.Notebook => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "communication", "social", "design"],
                Tags = ["notepad", "notes", "stationery", "sketchbook", "moleskine", "closure", "strap", "band", "elastic", "organizer", "organiser", "planner", "diary", "journal", "writing", "written", "writer", "reading", "high school", "university", "college", "academy", "student", "study", "homework", "research"],
            },
            LucideIconKind.NotebookPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["pencil", "notepad", "notes", "noted", "stationery", "sketchbook", "organizer", "organiser", "planner", "diary", "journal", "writing", "write", "written", "reading", "high school", "university", "college", "academy", "student", "study", "research", "homework", "eraser", "rubber"],
            },
            LucideIconKind.NotebookTabs => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account", "communication", "social"],
                Tags = ["notepad", "notes", "people", "family", "friends", "acquaintances", "contacts", "details", "addresses", "phone numbers", "directory", "listing", "networking", "alphabetical", "a-z", "organizer", "organiser", "planner", "diary", "stationery"],
            },
            LucideIconKind.NotebookText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["notepad", "notes", "pages", "paper", "stationery", "sketchbook", "organizer", "organiser", "planner", "diary", "journal", "writing", "write", "written", "reading", "high school", "university", "college", "academy", "student", "study", "research", "homework", "lines", "opened"],
            },
            LucideIconKind.NotepadText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["notebook", "notes", "pages", "paper", "stationery", "sketchbook", "organizer", "organiser", "planner", "diary", "journal", "writing", "write", "written", "reading", "high school", "university", "college", "academy", "student", "study", "homework", "research", "lines", "opened"],
            },
            LucideIconKind.NotepadTextDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["notebook", "notes", "pages", "paper", "stationery", "diary", "journal", "writing", "write", "written", "draft", "template", "lines"],
            },
            LucideIconKind.Nut => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["hazelnut", "acorn", "food", "diet"],
            },
            LucideIconKind.NutOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["hazelnut", "acorn", "food", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.Octagon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["shapes"],
                Tags = ["stop", "shape"],
            },
            LucideIconKind.OctagonAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas"],
                Categories = ["notifications", "shapes"],
                Tags = ["warning", "alert", "danger", "exclamation mark"],
            },
            LucideIconKind.OctagonMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["transportation"],
                Tags = ["stop", "forbidden", "subtract", "remove", "decrease", "reduce", "-", "traffic", "halt", "restricted"],
            },
            LucideIconKind.OctagonPause => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "jguddas"],
                Categories = ["multimedia", "shapes"],
                Tags = ["music", "audio", "stop"],
            },
            LucideIconKind.OctagonX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "notifications"],
                Tags = ["delete", "stop", "alert", "warning", "times", "clear", "math"],
            },
            LucideIconKind.Omega => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["math", "development", "text", "science"],
                Tags = ["greek", "symbol", "mathematics", "education", "physics", "engineering", "ohms", "electrical resistance", "angular frequency", "dynamical systems", "astronomy", "constellations", "philosophy"],
            },
            LucideIconKind.Option => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["keyboard", "key", "mac", "alt", "button"],
            },
            LucideIconKind.Orbit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["science"],
                Tags = ["planet", "space", "physics", "satellites", "moons"],
            },
            LucideIconKind.Origami => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["gurtt"],
                Categories = ["animals", "design"],
                Tags = ["paper", "bird"],
            },
            LucideIconKind.Package => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "danielbayley", "jguddas", "sezze"],
                Categories = ["files", "development"],
                Tags = ["box", "container", "storage", "sealed", "delivery", "undelivered", "unopened", "packed", "archive", "zip", "module"],
            },
            LucideIconKind.Package2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["files", "development"],
                Tags = ["box", "container", "storage", "sealed", "packed", "unopened", "undelivered", "archive", "zip"],
            },
            LucideIconKind.PackageCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Reund0", "ericfennis", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["confirm", "verified", "done", "todo", "tick", "complete", "task", "delivered"],
            },
            LucideIconKind.PackageMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Reund0", "ericfennis", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["delete", "remove"],
            },
            LucideIconKind.PackageOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["files", "development"],
                Tags = ["box", "container", "storage", "unpack", "unarchive", "unzip", "opened", "delivered"],
            },
            LucideIconKind.PackagePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Reund0", "ericfennis", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["new", "add", "create"],
            },
            LucideIconKind.PackageSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Reund0", "ericfennis", "karsa-mistmere"],
                Categories = ["files", "development"],
                Tags = ["find", "product process", "lens"],
            },
            LucideIconKind.PackageX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Reund0", "ericfennis", "karsa-mistmere"],
                Categories = ["development"],
                Tags = ["delete", "remove"],
            },
            LucideIconKind.PaintBucket => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["design", "tools"],
                Tags = ["fill", "paint", "bucket", "color", "colour"],
            },
            LucideIconKind.PaintRoller => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text", "design", "home", "tools"],
                Tags = ["brush", "color", "colour", "decoration", "diy"],
            },
            LucideIconKind.Paintbrush => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["text", "design", "photography", "home", "tools"],
                Tags = ["brush", "paintbrush", "design", "color", "colour", "decoration", "diy"],
            },
            LucideIconKind.PaintbrushVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["text", "design", "photography", "home", "tools"],
                Tags = ["brush", "paintbrush", "design", "color", "colour", "decoration", "diy"],
            },
            LucideIconKind.Palette => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["text", "design", "photography"],
                Tags = ["colors", "colours", "theme", "scheme", "paint", "watercolor", "watercolour", "artist"],
            },
            LucideIconKind.Panda => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme", "karsa-mistmere"],
                Categories = ["animals"],
                Tags = ["animal", "wildlife", "bear", "zoo", "bamboo"],
            },
            LucideIconKind.PanelBottom => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout"],
                Tags = ["drawer", "dock"],
            },
            LucideIconKind.PanelBottomClose => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["drawer", "dock", "hide", "chevron", "down"],
            },
            LucideIconKind.PanelBottomDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta"],
                Categories = ["layout"],
                Tags = ["drawer", "dock", "show", "reveal", "padding", "margin", "guide", "layout", "bleed"],
            },
            LucideIconKind.PanelBottomOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["drawer", "dock", "show", "reveal", "chevron", "up"],
            },
            LucideIconKind.PanelLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "danielbayley", "ericfennis"],
                Categories = ["layout"],
                Tags = ["primary", "drawer"],
            },
            LucideIconKind.PanelLeftClose => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["primary", "drawer", "hide", "chevron", "<"],
            },
            LucideIconKind.PanelLeftDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta"],
                Categories = ["layout"],
                Tags = ["sidebar", "primary", "drawer", "show", "reveal", "padding", "margin", "guide", "layout", "bleed"],
            },
            LucideIconKind.PanelLeftOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["primary", "drawer", "show", "reveal", "chevron", "right", ">"],
            },
            LucideIconKind.PanelLeftRightDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta", "jguddas"],
                Categories = ["layout"],
                Tags = ["sidebar", "primary", "drawer", "show", "reveal", "padding", "margin", "guide", "layout", "vertical", "bleed"],
            },
            LucideIconKind.PanelRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout"],
                Tags = ["sidebar", "secondary", "drawer"],
            },
            LucideIconKind.PanelRightClose => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["sidebar", "secondary", "drawer", "hide", "chevron", ">"],
            },
            LucideIconKind.PanelRightDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta"],
                Categories = ["layout"],
                Tags = ["sidebar", "secondary", "drawer", "show", "reveal", "padding", "margin", "guide", "layout", "bleed"],
            },
            LucideIconKind.PanelRightOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["sidebar", "secondary", "drawer", "show", "reveal", "chevron", "left", "<"],
            },
            LucideIconKind.PanelTop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "design", "development"],
                Tags = ["drawer", "browser", "webpage"],
            },
            LucideIconKind.PanelTopBottomDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta", "jguddas"],
                Categories = ["layout"],
                Tags = ["sidebar", "primary", "drawer", "show", "reveal", "padding", "margin", "guide", "layout", "horizontal", "bleed"],
            },
            LucideIconKind.PanelTopClose => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["menu bar", "drawer", "hide", "chevron", "up"],
            },
            LucideIconKind.PanelTopDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis", "irvineacosta"],
                Categories = ["layout"],
                Tags = ["menu bar", "drawer", "show", "reveal", "padding", "margin", "guide", "layout", "bleed"],
            },
            LucideIconKind.PanelTopOpen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["menu bar", "drawer", "show", "reveal", "chevron", "down"],
            },
            LucideIconKind.PanelsLeftBottom => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout"],
                Tags = ["drawers", "sidebar", "primary"],
            },
            LucideIconKind.PanelsRightBottom => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout"],
                Tags = ["drawers", "sidebar", "secondary"],
            },
            LucideIconKind.PanelsTopLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["layout", "design", "development"],
                Tags = ["menu bar", "sidebar", "primary", "drawers", "window", "webpage", "projects", "overview"],
            },
            LucideIconKind.Paperclip => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["text", "design", "files", "mail"],
                Tags = ["attachment", "file"],
            },
            LucideIconKind.Parentheses => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["development", "files", "math"],
                Tags = ["code", "token", "parenthesis", "parens", "brackets", "parameters", "arguments", "args", "input", "call", "math", "formula", "function", "(", ")"],
            },
            LucideIconKind.ParkingMeter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["transportation", "navigation"],
                Tags = ["driving", "car park", "pay", "sidewalk", "pavement"],
            },
            LucideIconKind.PartyPopper => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["emoji"],
                Tags = ["emoji", "congratulations", "celebration", "party", "tada", "🎉", "🎊", "excitement", "exciting", "excites", "confetti"],
            },
            LucideIconKind.Pause => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["music", "stop"],
            },
            LucideIconKind.PawPrint => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["animals"],
                Tags = ["pets", "vets", "veterinarian", "domesticated", "cat", "dog", "bear"],
            },
            LucideIconKind.PcCase => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["devices", "gaming"],
                Tags = ["computer", "chassis"],
            },
            LucideIconKind.Pen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "design", "tools"],
                Tags = ["pencil", "change", "create", "draw", "writer", "writing", "biro", "ink", "marker", "felt tip", "stationery", "artist"],
            },
            LucideIconKind.PenLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["text", "design", "tools"],
                Tags = ["pencil", "change", "create", "draw", "writer", "writing", "biro", "ink", "marker", "felt tip", "stationery", "artist"],
            },
            LucideIconKind.PenOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "design", "tools"],
                Tags = ["disabled", "inactive", "non-editable", "locked", "read-only", "unmodifiable", "frozen", "restricted", "pencil", "change", "create", "draw", "writer", "writing", "biro", "ink", "marker", "felt tip", "stationery", "artist"],
            },
            LucideIconKind.PenTool => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ashygee", "mittalyashu", "ericfennis", "jguddas"],
                Categories = ["text", "design", "cursors"],
                Tags = ["vector", "drawing", "path"],
            },
            LucideIconKind.Pencil => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "wojtekmaj", "mittalyashu", "danielbayley", "karsa-mistmere"],
                Categories = ["design", "cursors", "tools", "text"],
                Tags = ["rubber", "edit", "create", "draw", "sketch", "draft", "writer", "writing", "stationery", "artist"],
            },
            LucideIconKind.PencilLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["text", "design", "tools"],
                Tags = ["pencil", "change", "create", "draw", "sketch", "draft", "writer", "writing", "biro", "ink", "marker", "felt tip", "stationery", "artist"],
            },
            LucideIconKind.PencilOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "wojtekmaj", "mittalyashu", "danielbayley", "karsa-mistmere"],
                Categories = ["design", "cursors", "tools", "text"],
                Tags = ["disabled", "inactive", "non-editable", "locked", "read-only", "unmodifiable", "frozen", "restricted", "rubber", "edit", "create", "draw", "sketch", "draft", "writer", "writing", "stationery", "artist"],
            },
            LucideIconKind.PencilRuler => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["tools", "design", "layout", "text"],
                Tags = ["edit", "create", "draw", "sketch", "draft", "writer", "writing", "stationery", "artist", "measurements", "centimeters", "cm", "millimeters", "mm", "metre", "foot", "feet", "inches", "units", "size", "length", "width", "height", "dimensions", "depth", "breadth", "extent"],
            },
            LucideIconKind.Pentagon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["shapes"],
                Tags = ["shape"],
            },
            LucideIconKind.Percent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "development", "finance", "shopping"],
                Tags = ["percentage", "modulo", "modulus", "remainder", "%", "sale", "discount", "offer", "marketing"],
            },
            LucideIconKind.PersonStanding => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["accessibility", "people"],
                Tags = ["people", "human", "accessibility", "stick figure"],
            },
            LucideIconKind.PhilippinePeso => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "kasutu", "karsa-mistmere"],
                Categories = ["finance"],
                Tags = ["currency", "peso", "money", "php"],
            },
            LucideIconKind.Phone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jamiemlaw"],
                Categories = ["text", "connectivity", "devices", "communication"],
                Tags = ["call"],
            },
            LucideIconKind.PhoneCall => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw", "jguddas"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["ring"],
            },
            LucideIconKind.PhoneForwarded => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "connectivity", "devices", "communication"],
                Tags = ["call"],
            },
            LucideIconKind.PhoneIncoming => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "connectivity", "devices", "communication"],
                Tags = ["call"],
            },
            LucideIconKind.PhoneMissed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["call"],
            },
            LucideIconKind.PhoneOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["call", "mute"],
            },
            LucideIconKind.PhoneOutgoing => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "karsa-mistmere", "jamiemlaw"],
                Categories = ["arrows", "connectivity", "devices", "communication"],
                Tags = ["call"],
            },
            LucideIconKind.Pi => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development", "math"],
                Tags = ["constant", "code", "coding", "programming", "symbol", "trigonometry", "geometry", "formula"],
            },
            LucideIconKind.Piano => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "devices"],
                Tags = ["music", "audio", "sound", "noise", "notes", "chord", "keys", "octave", "acoustic", "instrument", "play", "pianist", "performance", "concert"],
            },
            LucideIconKind.Pickaxe => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["tools", "gaming"],
                Tags = ["mining", "mine", "land worker", "extraction", "labor", "construction", "progress", "advancement", "crafting", "building", "creation"],
            },
            LucideIconKind.PictureInPicture => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["cd16b", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["display", "play", "video", "pop out", "always on top", "window", "inset", "multitask"],
            },
            LucideIconKind.PictureInPicture2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["cd16b", "ericfennis"],
                Categories = ["multimedia"],
                Tags = ["display", "play", "video", "pop out", "always on top", "window", "inset", "multitask"],
            },
            LucideIconKind.PiggyBank => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jamiemlaw"],
                Categories = ["finance"],
                Tags = ["money", "savings"],
            },
            LucideIconKind.Pilcrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["paragraph", "mark", "paraph", "blind", "typography", "type", "text", "prose", "symbol"],
            },
            LucideIconKind.PilcrowLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zaaakher", "danielbayley", "jonas-hoebenreich"],
                Categories = ["text"],
                Tags = ["direction", "paragraph", "mark", "paraph", "blind", "typography", "type", "text", "prose", "symbol"],
            },
            LucideIconKind.PilcrowRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zaaakher", "danielbayley", "jonas-hoebenreich"],
                Categories = ["text"],
                Tags = ["direction", "paragraph", "mark", "paraph", "blind", "typography", "type", "text", "prose", "symbol"],
            },
            LucideIconKind.Pill => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["medical"],
                Tags = ["medicine", "medication", "drug", "prescription", "tablet", "pharmacy"],
            },
            LucideIconKind.PillBottle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["medical"],
                Tags = ["medicine", "medication", "prescription", "drug", "supplement", "vitamin", "capsule", "jar", "container", "healthcare", "pharmaceutical", "tablet"],
            },
            LucideIconKind.Pin => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["navigation", "account"],
                Tags = ["save", "map", "lock", "fix"],
            },
            LucideIconKind.PinOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["navigation"],
                Tags = ["unpin", "map", "unlock", "unfix", "unsave", "remove"],
            },
            LucideIconKind.Pipette => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["text", "design", "science"],
                Tags = ["eye dropper", "color picker", "lab", "chemistry"],
            },
            LucideIconKind.Pizza => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas", "jamiemlaw"],
                Categories = ["food-beverage"],
                Tags = ["pie", "quiche", "food"],
            },
            LucideIconKind.Plane => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "csandman", "ericfennis"],
                Categories = ["transportation", "travel"],
                Tags = ["plane", "trip", "airplane"],
            },
            LucideIconKind.PlaneLanding => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["transportation", "travel"],
                Tags = ["arrival", "plane", "trip", "airplane", "landing"],
            },
            LucideIconKind.PlaneTakeoff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["transportation", "travel"],
                Tags = ["departure", "plane", "trip", "airplane", "takeoff"],
            },
            LucideIconKind.Play => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["arrows", "multimedia"],
                Tags = ["music", "audio", "video", "start", "run"],
            },
            LucideIconKind.Plug => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "danielbayley", "karsa-mistmere"],
                Categories = ["devices", "development"],
                Tags = ["electricity", "energy", "electronics", "socket", "outlet"],
            },
            LucideIconKind.Plug2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["devices", "development"],
                Tags = ["electricity", "energy", "socket", "outlet"],
            },
            LucideIconKind.PlugZap => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas", "danielbayley", "karsa-mistmere"],
                Categories = ["devices"],
                Tags = ["electricity", "energy", "electronics", "charge", "charging", "battery", "connect"],
            },
            LucideIconKind.Plus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "tools", "development", "text", "cursors", "gaming"],
                Tags = ["add", "new", "increase", "increment", "positive", "calculate", "toolbar", "crosshair", "aim", "target", "scope", "sight", "reticule", "maximum", "upgrade", "extra", "+"],
            },
            LucideIconKind.Pocket => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["brands"],
                Tags = ["logo", "save"],
            },
            LucideIconKind.PocketKnife => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["tools"],
                Tags = ["swiss army knife", "penknife", "multi-tool", "multitask", "blade", "cutter", "gadget", "corkscrew"],
            },
            LucideIconKind.Podcast => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["iiaishwarya", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["multimedia", "social"],
                Tags = ["audio", "music", "mic", "talk", "voice", "subscribe", "subscription", "stream"],
            },
            LucideIconKind.Pointer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["cursors"],
                Tags = ["mouse"],
            },
            LucideIconKind.PointerOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["cursors"],
                Tags = ["mouse"],
            },
            LucideIconKind.Popcorn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage", "multimedia"],
                Tags = ["cinema", "movies", "films", "salted", "sweet", "sugar", "candy", "snack"],
            },
            LucideIconKind.Popsicle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["food-beverage"],
                Tags = ["ice lolly", "ice cream", "sweet", "food"],
            },
            LucideIconKind.PoundSterling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Power => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["connectivity"],
                Tags = ["on", "off", "device", "switch", "toggle", "binary", "boolean", "reboot", "restart", "button", "keyboard", "troubleshoot"],
            },
            LucideIconKind.PowerOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["connectivity"],
                Tags = ["on", "off", "device", "switch"],
            },
            LucideIconKind.Presentation => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley"],
                Categories = ["multimedia", "photography", "devices", "communication", "design"],
                Tags = ["screen", "whiteboard", "marker pens", "markers", "blackboard", "chalk", "easel", "school", "learning", "lesson", "office", "meeting", "project", "planning"],
            },
            LucideIconKind.Printer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["devices"],
                Tags = ["fax", "office", "device"],
            },
            LucideIconKind.PrinterCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["devices"],
                Tags = ["fax", "office", "device", "success", "printed"],
            },
            LucideIconKind.Projector => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["multimedia", "photography", "devices", "communication"],
                Tags = ["cinema", "film", "movie", "home video", "presentation", "slideshow", "office", "meeting", "project", "planning"],
            },
            LucideIconKind.Proportions => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "photography", "devices"],
                Tags = ["screens", "sizes", "rotate", "rotation", "adjust", "aspect ratio", "16:9", "widescreen", "4:3", "resolution", "responsive", "mobile", "desktop", "dimensions", "monitor", "orientation", "portrait", "landscape"],
            },
            LucideIconKind.Puzzle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["development", "gaming"],
                Tags = ["component", "module", "part", "piece"],
            },
            LucideIconKind.Pyramid => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "math", "travel"],
                Tags = ["prism", "triangle", "triangular", "hierarchy", "structure", "geometry", "ancient", "egyptian", "landmark", "tourism"],
            },
            LucideIconKind.QrCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["development", "social"],
                Tags = ["barcode", "scan", "link", "url", "information", "digital"],
            },
            LucideIconKind.Quote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Billiam", "jguddas", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["quotation"],
            },
            LucideIconKind.Rabbit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["animals"],
                Tags = ["animal", "rodent", "pet", "pest", "bunny", "hare", "fast", "speed", "hop"],
            },
            LucideIconKind.Radar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["navigation", "security", "communication"],
                Tags = ["scan", "sonar", "detect", "find", "locate"],
            },
            LucideIconKind.Radiation => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "ericfennis"],
                Categories = ["science"],
                Tags = ["radioactive", "nuclear", "fallout", "waste", "atomic", "physics", "particle", "element", "molecule"],
            },
            LucideIconKind.Radical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["smnandre", "jguddas"],
                Categories = ["development", "math"],
                Tags = ["calculate", "formula", "math", "operator", "root", "square", "symbol"],
            },
            LucideIconKind.Radio => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["devices", "multimedia", "social"],
                Tags = ["signal", "broadcast", "connectivity", "live", "frequency"],
            },
            LucideIconKind.RadioReceiver => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["devices"],
                Tags = ["device", "music", "connect"],
            },
            LucideIconKind.RadioTower => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["devices", "multimedia", "social"],
                Tags = ["signal", "broadcast", "connectivity", "live", "frequency"],
            },
            LucideIconKind.Radius => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "math", "design", "tools"],
                Tags = ["shape", "circle", "geometry", "trigonometry", "radii", "calculate", "measure", "size"],
            },
            LucideIconKind.RailSymbol => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "navigation"],
                Tags = ["railway", "train", "track", "line"],
            },
            LucideIconKind.Rainbow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["weather"],
                Tags = ["colors", "colours", "spectrum", "light", "prism", "arc", "clear", "sunshine"],
            },
            LucideIconKind.Rat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["henri42", "jguddas", "karsa-mistmere", "danielbayley"],
                Categories = ["animals"],
                Tags = ["mouse", "mice", "gerbil", "rodent", "pet", "pest", "plague", "disease"],
            },
            LucideIconKind.Ratio => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "photography"],
                Tags = ["screens", "sizes", "rotate", "rotation", "adjust", "aspect ratio", "proportions", "16:9", "widescreen", "4:3", "resolution", "responsive", "mobile", "desktop", "dimensions", "monitor", "orientation", "portrait", "landscape"],
            },
            LucideIconKind.Receipt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not", "ericfennis"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "dollar", "usd", "$"],
            },
            LucideIconKind.ReceiptCent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "cents", "dollar", "usd", "$", "¢"],
            },
            LucideIconKind.ReceiptEuro => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "€"],
            },
            LucideIconKind.ReceiptIndianRupee => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "inr", "₹"],
            },
            LucideIconKind.ReceiptJapaneseYen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not", "ericfennis"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "jpy", "¥"],
            },
            LucideIconKind.ReceiptPoundSterling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "british", "currency", "gbp", "£"],
            },
            LucideIconKind.ReceiptRussianRuble => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "rub", "₽"],
            },
            LucideIconKind.ReceiptSwissFranc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "chf", "₣"],
            },
            LucideIconKind.ReceiptText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "details", "small print", "terms", "conditions", "contract"],
            },
            LucideIconKind.ReceiptTurkishLira => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jamiemlaw"],
                Categories = ["finance", "travel"],
                Tags = ["bill", "voucher", "slip", "check", "counterfoil", "currency", "try", "₺"],
            },
            LucideIconKind.RectangleCircle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zefir-git", "jguddas"],
                Categories = ["development", "text"],
                Tags = ["compose", "keyboard", "key", "button"],
            },
            LucideIconKind.RectangleEllipsis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["text", "development"],
                Tags = ["login", "password", "authenticate", "2fa", "field", "fill", "ellipsis", "et cetera", "etc", "loader", "loading", "progress", "pending", "throbber", "menu", "options", "operator", "code", "spread", "rest", "more", "further", "extra", "overflow", "dots", "…", "..."],
            },
            LucideIconKind.RectangleGoggles => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "jguddas"],
                Categories = ["devices", "gaming", "multimedia", "connectivity"],
                Tags = ["vr", "virtual", "augmented", "reality", "headset", "goggles"],
            },
            LucideIconKind.RectangleHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "Reund0", "danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["shapes", "design"],
                Tags = ["rectangle", "aspect ratio", "16:9", "horizontal", "shape"],
            },
            LucideIconKind.RectangleVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "Reund0", "danielbayley", "karsa-mistmere", "ericfennis"],
                Categories = ["shapes", "design"],
                Tags = ["rectangle", "aspect ratio", "9:16", "vertical", "shape"],
            },
            LucideIconKind.Recycle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["sustainability"],
                Tags = ["sustainability", "salvage", "arrows"],
            },
            LucideIconKind.Redo => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["aelfric", "ericfennis", "csandman"],
                Categories = ["text", "arrows"],
                Tags = ["undo", "rerun", "history"],
            },
            LucideIconKind.Redo2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "danielbayley", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["undo", "rerun", "history"],
            },
            LucideIconKind.RedoDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["redo", "history", "step", "over", "forward"],
            },
            LucideIconKind.RefreshCcw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows"],
                Tags = ["arrows", "rotate", "reload", "rerun", "synchronise", "synchronize", "circular", "cycle"],
            },
            LucideIconKind.RefreshCcwDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis", "danielbayley", "jamiemlaw"],
                Categories = ["arrows", "development"],
                Tags = ["arrows", "rotate", "reload", "synchronise", "synchronize", "circular", "cycle", "issue", "code", "coding", "version control"],
            },
            LucideIconKind.RefreshCw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows"],
                Tags = ["rotate", "reload", "rerun", "synchronise", "synchronize", "arrows", "circular", "cycle"],
            },
            LucideIconKind.RefreshCwOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows"],
                Tags = ["rotate", "reload", "rerun", "synchronise", "synchronize", "arrows", "circular", "cycle", "cancel", "no", "stop", "error", "disconnect", "ignore"],
            },
            LucideIconKind.Refrigerator => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage", "home"],
                Tags = ["frigerator", "fridge", "freezer", "cooler", "icebox", "chiller", "cold storage"],
            },
            LucideIconKind.Regex => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["text", "development"],
                Tags = ["search", "text", "code"],
            },
            LucideIconKind.RemoveFormatting => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text"],
                Tags = ["text", "font", "typography", "format", "x", "remove", "delete", "times", "clear"],
            },
            LucideIconKind.Repeat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "multimedia"],
                Tags = ["loop", "arrows"],
            },
            LucideIconKind.Repeat1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["multimedia"],
                Tags = ["replay"],
            },
            LucideIconKind.Repeat2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["arrows", "social", "multimedia"],
                Tags = ["arrows", "retweet", "repost", "share", "repeat", "loop"],
            },
            LucideIconKind.Replace => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["search", "substitute", "swap", "change"],
            },
            LucideIconKind.ReplaceAll => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["search", "substitute", "swap", "change"],
            },
            LucideIconKind.Reply => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "mittalyashu"],
                Categories = ["mail"],
                Tags = ["email"],
            },
            LucideIconKind.ReplyAll => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "mittalyashu"],
                Categories = ["mail"],
                Tags = ["email"],
            },
            LucideIconKind.Rewind => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["arrows", "multimedia"],
                Tags = ["music"],
            },
            LucideIconKind.Ribbon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["social", "medical", "emoji"],
                Tags = ["awareness", "strip", "band", "tape", "strap", "cordon"],
            },
            LucideIconKind.Rocket => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["gaming", "development"],
                Tags = ["release", "boost", "launch", "space", "version"],
            },
            LucideIconKind.RockingChair => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["connium", "ericfennis"],
                Categories = ["home"],
                Tags = ["chair", "furniture", "seat"],
            },
            LucideIconKind.RollerCoaster => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["attraction", "entertainment", "amusement park", "theme park", "funfair"],
            },
            LucideIconKind.Rose => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "jamiemlaw", "mittalyashu"],
                Categories = ["nature", "seasons", "sustainability", "home", "social"],
                Tags = ["roses", "thorns", "petals", "plant", "stem", "leaves", "spring", "bloom", "blossom", "gardening", "botanical", "flora", "florist", "bouquet", "bunch", "gift", "date", "romance", "romantic", "valentines day", "special occasion"],
            },
            LucideIconKind.Rotate3d => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel"],
                Categories = ["design"],
                Tags = ["gizmo", "transform", "orientation", "orbit", "axis"],
            },
            LucideIconKind.RotateCcw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows", "design", "photography"],
                Tags = ["arrow", "left", "counter-clockwise", "restart", "reload", "rerun", "refresh", "backup", "undo", "replay", "redo", "retry", "rewind", "reverse"],
            },
            LucideIconKind.RotateCcwKey => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "pgbradbury", "jguddas"],
                Categories = ["security", "account"],
                Tags = ["password", "key", "refresh", "change"],
            },
            LucideIconKind.RotateCcwSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "photography", "tools", "arrows"],
                Tags = ["left", "counter-clockwise", "rotate", "image", "90", "45", "degrees", "°"],
            },
            LucideIconKind.RotateCw => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["arrows", "design", "photography"],
                Tags = ["arrow", "right", "clockwise", "refresh", "reload", "rerun", "redo"],
            },
            LucideIconKind.RotateCwSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "photography", "tools", "arrows"],
                Tags = ["right", "clockwise", "rotate", "image", "90", "45", "degrees", "°"],
            },
            LucideIconKind.Route => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["navigation"],
                Tags = ["path", "journey", "planner", "points", "stops", "stations"],
            },
            LucideIconKind.RouteOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["navigation"],
                Tags = ["path", "journey", "planner", "points", "stops", "stations", "reset", "clear", "cancelled", "closed", "blocked"],
            },
            LucideIconKind.Router => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["FrancoMaxime", "ericfennis", "karsa-mistmere"],
                Categories = ["development", "devices", "connectivity", "home"],
                Tags = ["computer", "server", "cloud"],
            },
            LucideIconKind.Rows2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "text"],
                Tags = ["lines", "list", "queue", "preview", "panel", "paragraphs", "parallel", "series", "split", "vertical", "horizontal", "half", "center", "middle", "even", "drawer"],
            },
            LucideIconKind.Rows3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "text"],
                Tags = ["lines", "list", "queue", "preview", "paragraphs", "parallel", "series", "split", "vertical", "horizontal", "half", "center", "middle", "even", "drawers"],
            },
            LucideIconKind.Rows4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout", "design", "text"],
                Tags = ["lines", "list", "queue", "preview", "paragraphs", "parallel", "series", "split", "vertical", "horizontal", "half", "center", "middle", "even", "drawers", "grill"],
            },
            LucideIconKind.Rss => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["development", "social"],
                Tags = ["feed", "subscribe", "news", "updates", "notifications", "content", "blog", "articles", "broadcast", "syndication", "reader", "channels", "posts", "publishing", "digest", "alert", "following", "inbox", "newsletter", "weblog", "podcast"],
            },
            LucideIconKind.Ruler => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["tools", "design", "layout"],
                Tags = ["measurements", "centimeters", "cm", "millimeters", "mm", "metre", "foot", "feet", "inches", "units", "size", "length", "width", "height", "dimensions", "depth", "breadth", "extent", "stationery"],
            },
            LucideIconKind.RulerDimensionLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas"],
                Categories = ["tools", "design", "layout"],
                Tags = ["measurements", "centimeters", "cm", "millimeters", "mm", "metre", "foot", "feet", "inches", "units", "size", "length", "width", "height", "dimensions", "depth", "breadth", "extent", "stationery"],
            },
            LucideIconKind.RussianRuble => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Sailboat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["transportation", "travel"],
                Tags = ["ship", "boat", "harbor", "harbour", "dock"],
            },
            LucideIconKind.Salad => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie"],
                Categories = ["food-beverage", "emoji"],
                Tags = ["food", "vegetarian", "dish", "restaurant", "course", "meal", "side", "vegetables", "health"],
            },
            LucideIconKind.Sandwich => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie", "jamiemlaw"],
                Categories = ["food-beverage"],
                Tags = ["food", "snack", "dish", "restaurant", "lunch", "meal"],
            },
            LucideIconKind.Satellite => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["connectivity", "science"],
                Tags = ["space station", "orbit", "transmitter"],
            },
            LucideIconKind.SatelliteDish => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["connectivity", "devices", "multimedia"],
                Tags = ["antenna", "receiver", "dish aerial", "saucer"],
            },
            LucideIconKind.SaudiRiyal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["null78", "jguddas"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Save => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["text", "files"],
                Tags = ["floppy disk"],
            },
            LucideIconKind.SaveAll => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["text", "files"],
                Tags = ["floppy disks", "copy"],
            },
            LucideIconKind.SaveOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev"],
                Categories = ["text", "files"],
                Tags = ["floppy disk", "unsalvageable"],
            },
            LucideIconKind.Scale => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["navigation"],
                Tags = ["balance", "legal", "license", "right", "rule", "law"],
            },
            LucideIconKind.Scale3d => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "ericfennis", "jguddas"],
                Categories = ["design"],
                Tags = ["gizmo", "transform", "size", "axis"],
            },
            LucideIconKind.Scaling => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["design"],
                Tags = ["scale", "resize", "design"],
            },
            LucideIconKind.Scan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis"],
                Categories = ["devices", "shopping", "security", "social", "gaming"],
                Tags = ["qr-code", "barcode", "checkout", "augmented reality", "ar", "target", "surveillance", "camera", "lens", "focus", "frame", "select", "box", "boundary", "bounds", "area", "square", "dashed"],
            },
            LucideIconKind.ScanBarcode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping", "devices"],
                Tags = ["checkout", "till", "cart", "transaction", "purchase", "buy", "product", "packaging", "retail", "consumer"],
            },
            LucideIconKind.ScanEye => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["photography", "multimedia", "accessibility", "security", "devices", "account"],
                Tags = ["preview", "zoom", "expand", "fullscreen", "gallery", "image", "camera", "watch", "surveillance", "retina", "focus", "lens", "biometric", "identification", "authentication", "access", "login"],
            },
            LucideIconKind.ScanFace => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account", "security", "devices", "social"],
                Tags = ["face", "biometric", "identification", "authentication", "2fa", "access", "login", "dashed"],
            },
            LucideIconKind.ScanHeart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["medical"],
                Tags = ["health", "heart rate", "pulse", "monitoring", "healthiness", "screening", "dashed"],
            },
            LucideIconKind.ScanLine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["wojtekmaj", "ericfennis"],
                Categories = ["devices", "shopping"],
                Tags = ["checkout", "till", "cart", "transaction", "purchase", "buy", "product", "packaging", "retail", "consumer", "qr-code", "dashed"],
            },
            LucideIconKind.ScanQrCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "vexkiddy"],
                Categories = ["account", "shopping", "devices", "security"],
                Tags = ["barcode", "scan", "qrcode", "url", "information", "digital", "scanner"],
            },
            LucideIconKind.ScanSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["photography", "multimedia", "accessibility"],
                Tags = ["preview", "zoom", "expand", "fullscreen", "gallery", "image", "focus", "lens"],
            },
            LucideIconKind.ScanText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "devices"],
                Tags = ["recognition", "read", "translate", "copy", "lines"],
            },
            LucideIconKind.School => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "navigation"],
                Tags = ["building", "education", "childhood", "university", "learning", "campus", "scholar", "student", "lecture", "degree", "course", "academia", "study", "knowledge", "classroom", "research", "diploma", "graduation", "professor", "tutorial", "homework", "assignment", "exam"],
            },
            LucideIconKind.Scissors => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["text", "design", "tools"],
                Tags = ["cut", "snip", "chop", "stationery", "crafts"],
            },
            LucideIconKind.ScissorsLineDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["design", "tools"],
                Tags = ["cut here", "along", "snip", "chop", "stationery", "crafts", "instructions", "diagram"],
            },
            LucideIconKind.ScreenShare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis", "johnletey"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["host", "desktop", "monitor"],
            },
            LucideIconKind.ScreenShareOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis", "johnletey"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["desktop", "disconnect", "monitor"],
            },
            LucideIconKind.Scroll => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["gaming", "development", "text"],
                Tags = ["paper", "log", "scripture", "document", "notes", "parchment", "list", "long", "script", "story", "code", "coding"],
            },
            LucideIconKind.ScrollText => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["gaming", "development", "text"],
                Tags = ["paper", "log", "scripture", "document", "notes", "parchment", "list", "long", "script", "story", "code", "coding"],
            },
            LucideIconKind.Search => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas"],
                Categories = ["text", "social"],
                Tags = ["find", "scan", "magnifier", "magnifying glass", "lens"],
            },
            LucideIconKind.SearchCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["find", "scan", "magnifier", "magnifying glass", "found", "correct", "complete", "tick", "lens"],
            },
            LucideIconKind.SearchCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "social", "development"],
                Tags = ["find", "scan", "magnifier", "magnifying glass", "grep", "chevrons", "<>", "lens"],
            },
            LucideIconKind.SearchSlash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["find", "scan", "magnifier", "magnifying glass", "stop", "clear", "cancel", "abort", "/", "lens"],
            },
            LucideIconKind.SearchX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "social"],
                Tags = ["find", "scan", "magnifier", "magnifying glass", "stop", "clear", "cancel", "abort", "lens"],
            },
            LucideIconKind.Section => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["gurtt", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["mark", "typography", "punctuation", "legal", "type", "text", "prose", "symbol"],
            },
            LucideIconKind.Send => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["mail", "communication", "connectivity"],
                Tags = ["email", "message", "mail", "paper airplane", "paper aeroplane", "submit"],
            },
            LucideIconKind.SendHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["mail", "communication", "connectivity"],
                Tags = ["email", "message", "mail", "paper airplane", "paper aeroplane", "submit"],
            },
            LucideIconKind.SendToBack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["james-yeoman", "jguddas"],
                Categories = ["design", "layout"],
                Tags = ["bring", "send", "move", "under", "back", "backwards", "overlap", "layer", "order"],
            },
            LucideIconKind.SeparatorHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text", "arrows", "layout"],
                Tags = ["move", "split"],
            },
            LucideIconKind.SeparatorVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text", "arrows", "layout"],
                Tags = ["move", "split"],
            },
            LucideIconKind.Server => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["development", "devices"],
                Tags = ["cloud", "storage"],
            },
            LucideIconKind.ServerCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "UsamaKhan"],
                Categories = ["development", "devices"],
                Tags = ["cloud", "storage", "computing", "cog", "gear"],
            },
            LucideIconKind.ServerCrash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["development", "devices"],
                Tags = ["cloud", "storage", "problem", "error"],
            },
            LucideIconKind.ServerOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["yukosgiti", "ericfennis", "csandman"],
                Categories = ["development", "devices"],
                Tags = ["cloud", "storage"],
            },
            LucideIconKind.Settings => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["cog", "edit", "gear", "preferences"],
            },
            LucideIconKind.Settings2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas"],
                Categories = ["account"],
                Tags = ["cog", "edit", "gear", "preferences", "slider"],
            },
            LucideIconKind.Shapes => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "gaming"],
                Tags = ["triangle", "equilateral", "square", "circle", "classification", "different", "collection", "toy", "blocks", "learning"],
            },
            LucideIconKind.Share => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["account", "social"],
                Tags = ["network", "connections"],
            },
            LucideIconKind.Share2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["account", "social"],
                Tags = ["network", "connections"],
            },
            LucideIconKind.Sheet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zenoamaro", "ericfennis", "csandman", "mittalyashu"],
                Categories = ["text", "files"],
                Tags = ["spreadsheets", "table", "excel"],
            },
            LucideIconKind.Shell => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["animals", "development", "nature", "science", "travel", "food-beverage", "home"],
                Tags = ["beach", "sand", "holiday", "sealife", "fossil", "ammonite", "biology", "ocean", "terminal", "command line", "session", "bash", "zsh", "roll", "wrap", "chewing gum", "bubble gum", "sweet", "sugar", "hosepipe", "carpet", "string", "spiral", "spinner", "hypnotise", "hypnosis"],
            },
            LucideIconKind.Shield => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming", "shapes"],
                Tags = ["cybersecurity", "secure", "safety", "protection", "guardian", "armored", "armoured", "defense", "defence", "defender", "block", "threat", "prevention", "antivirus", "vigilance", "vigilant", "detection", "scan", "find", "strength", "strong", "tough", "invincible", "invincibility", "invulnerable", "undamaged", "audit", "admin", "verification", "crest", "bravery", "knight", "foot soldier", "infantry", "trooper", "pawn", "battle", "war", "military", "army", "cadet", "scout"],
            },
            LucideIconKind.ShieldAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "security", "development", "notifications", "gaming"],
                Tags = ["unshielded", "cybersecurity", "insecure", "unsecured", "safety", "unsafe", "protection", "unprotected", "guardian", "unguarded", "unarmored", "unarmoured", "defenseless", "defenceless", "undefended", "defender", "blocked", "stopped", "intercepted", "interception", "saved", "thwarted", "threat", "prevention", "unprevented", "antivirus", "vigilance", "vigilant", "detection", "detected", "scanned", "found", "exploit", "vulnerability", "vulnerable", "weakness", "infection", "infected", "comprimised", "data leak", "audited", "admin", "verification", "unverified", "uncertified", "warning", "emergency", "attention", "urgent", "alarm", "crest", "bravery", "strength", "tough", "attacked", "damaged", "injured", "hit", "expired", "disabled", "inactive", "error", "exclamation mark", "!"],
            },
            LucideIconKind.ShieldBan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["unshielded", "cybersecurity", "insecure", "unsecured", "safety", "unsafe", "protection", "unprotected", "guardian", "unguarded", "unarmored", "unarmoured", "defenseless", "defenceless", "undefended", "defender", "blocked", "stopped", "intercepted", "interception", "saved", "thwarted", "threat", "prevention", "unprevented", "antivirus", "vigilance", "vigilant", "detection", "detected", "scanned", "found", "exploit", "vulnerability", "vulnerable", "weakness", "infection", "infected", "comprimised", "data leak", "audited", "admin", "verification", "unverified", "uncertified", "cancel", "error", "crest", "bravery", "attacked", "damaged", "injured", "hit", "expired", "eliminated", "disabled", "inactive", "/"],
            },
            LucideIconKind.ShieldCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["cybersecurity", "secured", "safety", "protection", "protected", "guardian", "guarded", "armored", "armoured", "defense", "defence", "defended", "blocked", "threat", "prevention", "prevented", "antivirus", "vigilance", "vigilant", "active", "activated", "enabled", "detection", "scanned", "found", "strength", "strong", "tough", "invincible", "invincibility", "invulnerable", "undamaged", "audited", "admin", "verification", "verified", "certification", "certified", "tested", "passed", "qualified", "cleared", "cleaned", "disinfected", "uninfected", "task", "completed", "todo", "done", "ticked", "checked", "crest", "bravery"],
            },
            LucideIconKind.ShieldEllipsis => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["cybersecurity", "securing", "protecting", "guarding", "armoring", "armouring", "defending", "blocking", "preventing", "antivirus", "detecting", "scanning", "finding", "auditing", "admin", "verifying", "crest", "upgrading", "loader", "loading", "throbber", "progress", "dots", "more", "etc", "...", "…"],
            },
            LucideIconKind.ShieldHalf => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["cybersecurity", "secure", "safety", "protection", "guardian", "armored", "armoured", "defense", "defence", "defender", "block", "threat", "prevention", "antivirus", "vigilance", "vigilant", "detection", "scan", "strength", "strong", "tough", "invincible", "invincibility", "invulnerable", "undamaged", "audit", "admin", "verification", "crest", "logo", "sigil", "flag", "team", "faction", "fraternity", "university", "college", "academy", "school", "education", "uniform", "bravery", "knight", "foot soldier", "infantry", "trooper", "pawn", "battle", "war", "military", "ranking", "army", "cadet", "scout"],
            },
            LucideIconKind.ShieldMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["unshield", "cybersecurity", "unsecure", "unguard", "unblock", "antivirus", "clean", "clear", "disinfect", "patch", "fix", "stop", "cancel", "remove", "relax", "admin", "crest", "bravery", "weakened", "damaged", "hit", "unarm", "disable", "deactivate", "decommission", "downgraded", "minimum", "-"],
            },
            LucideIconKind.ShieldOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["unshielded", "cybersecurity", "insecure", "unsecured", "safety", "unsafe", "protection", "unprotected", "guardian", "unguarded", "unarmored", "unarmoured", "defenseless", "defenceless", "undefended", "defender", "interception", "threat", "prevention", "unprevented", "antivirus", "detection", "undetected", "exploit", "vulnerability", "vulnerable", "weakness", "infected", "infection", "comprimised", "data leak", "unaudited", "admin", "verification", "unverified", "inactive", "cancelled", "error", "crest", "bravery", "damaged", "injured", "hit", "expired", "eliminated"],
            },
            LucideIconKind.ShieldPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming", "medical"],
                Tags = ["cybersecurity", "secure", "safety", "protection", "guardian", "armored", "armoured", "defense", "defence", "defender", "block", "threat", "prevention", "antivirus", "vigilance", "vigilant", "detection", "scan", "strength", "strong", "tough", "invincible", "invincibility", "invulnerable", "undamaged", "extra", "added", "professional", "enterprise", "full", "maximum", "upgraded", "ultra", "activate", "enable", "audit", "admin", "verification", "crest", "medic", "+"],
            },
            LucideIconKind.ShieldQuestionMark => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["unshielded", "cybersecurity", "insecure", "unsecured", "safety", "unsafe", "protection", "unprotected", "guardian", "unguarded", "unarmored", "unarmoured", "defenseless", "defenceless", "undefended", "defender", "threat", "prevention", "unprevented", "antivirus", "vigilance", "vigilant", "detection", "undetected", "scan", "find", "exploit", "vulnerability", "vulnerable", "weakness", "infection", "comprimised", "data leak", "audit", "admin", "verification", "unverified", "uncertified", "uncertain", "unknown", "inactive", "crest", "question mark", "?"],
            },
            LucideIconKind.ShieldUser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["sebinemeth", "ksk3110", "karsa-mistmere", "colebemis"],
                Categories = ["account", "security", "development"],
                Tags = ["shield", "user", "admin", "protection", "protected", "safety", "guard"],
            },
            LucideIconKind.ShieldX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "security", "development", "gaming"],
                Tags = ["unshielded", "cybersecurity", "insecure", "unsecured", "safety", "unsafe", "protection", "unprotected", "guardian", "unguarded", "unarmored", "unarmoured", "defenseless", "defenceless", "undefended", "defender", "blocked", "stopped", "intercepted", "interception", "saved", "thwarted", "threat", "prevention", "prevented", "antivirus", "vigilance", "vigilant", "detection", "detected", "scanned", "found", "exploit", "vulnerability", "vulnerable", "weakness", "infection", "infected", "comprimised", "data leak", "audited", "admin", "verification", "unverified", "inactive", "cancel", "error", "wrong", "false", "crest", "bravery", "attacked", "damaged", "injured", "hit", "dead", "deceased", "expired", "eliminated", "exterminated"],
            },
            LucideIconKind.Ship => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["transportation", "navigation", "travel"],
                Tags = ["boat", "knots", "nautical mile", "maritime", "sailing", "yacht", "cruise", "ocean liner", "tanker", "vessel", "navy", "trip", "releases"],
            },
            LucideIconKind.ShipWheel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "navigation", "travel"],
                Tags = ["steering", "rudder", "boat", "knots", "nautical mile", "maritime", "sailing", "yacht", "cruise", "ocean liner", "tanker", "vessel", "navy", "trip"],
            },
            LucideIconKind.Shirt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "csandman", "ericfennis"],
                Categories = ["shopping"],
                Tags = ["t-shirt", "shopping", "store", "clothing", "clothes"],
            },
            LucideIconKind.ShoppingBag => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["shopping"],
                Tags = ["ecommerce", "cart", "purchase", "store"],
            },
            LucideIconKind.ShoppingBasket => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shopping"],
                Tags = ["cart", "e-commerce", "store", "purchase", "products", "items", "ingredients"],
            },
            LucideIconKind.ShoppingCart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["shopping"],
                Tags = ["trolley", "cart", "basket", "e-commerce", "store", "purchase", "products", "items", "ingredients"],
            },
            LucideIconKind.Shovel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "karsa-mistmere"],
                Categories = ["nature", "tools", "gaming"],
                Tags = ["dig", "spade", "treasure"],
            },
            LucideIconKind.ShowerHead => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home", "travel"],
                Tags = ["shower", "bath", "bathroom", "amenities", "services"],
            },
            LucideIconKind.Shredder => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Alirashidy", "colebemis", "danielbayley", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["mail", "files"],
                Tags = ["file", "paper", "tear", "cut", "delete", "destroy", "remove", "erase", "document", "destruction", "secure", "security", "confidential", "data", "trash", "dispose", "disposal", "information", "waste", "permanent"],
            },
            LucideIconKind.Shrimp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["animals"],
                Tags = ["seafood", "shellfish", "crustacean", "prawn", "scallop", "whelk", "arthropod", "littleneck", "quahog", "cherrystone"],
            },
            LucideIconKind.Shrink => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["layout", "arrows"],
                Tags = ["scale", "fullscreen"],
            },
            LucideIconKind.Shrub => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["nature"],
                Tags = ["forest", "undergrowth", "park", "nature"],
            },
            LucideIconKind.Shuffle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["multimedia", "arrows"],
                Tags = ["music", "random", "reorder"],
            },
            LucideIconKind.Sigma => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "johnletey", "ericfennis"],
                Categories = ["text", "math", "science"],
                Tags = ["sum", "calculate", "formula", "math", "enumeration", "enumerate"],
            },
            LucideIconKind.Signal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["connectivity"],
                Tags = ["connection", "wireless", "gsm", "phone", "2g", "3g", "4g", "5g"],
            },
            LucideIconKind.SignalHigh => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["connectivity"],
                Tags = ["connection", "wireless", "gsm", "phone", "2g", "3g", "4g", "5g"],
            },
            LucideIconKind.SignalLow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["connectivity"],
                Tags = ["connection", "wireless", "gsm", "phone", "2g", "3g", "4g", "5g"],
            },
            LucideIconKind.SignalMedium => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["connectivity"],
                Tags = ["connection", "wireless", "gsm", "phone", "2g", "3g", "4g", "5g"],
            },
            LucideIconKind.SignalZero => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "azdle"],
                Categories = ["connectivity"],
                Tags = ["connection", "wireless", "gsm", "phone", "2g", "3g", "4g", "5g", "lost"],
            },
            LucideIconKind.Signature => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AnnaSasDev", "jguddas"],
                Categories = ["text"],
                Tags = ["text", "format", "input", "contract", "autograph", "handwriting", "sign", "cursive", "ink", "scribble", "authorize", "personal", "agreement", "legal", "document", "identity", "authentic", "approval", "verification", "unique"],
            },
            LucideIconKind.Signpost => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["arrows", "navigation", "development", "gaming"],
                Tags = ["bidirectional", "left", "right", "east", "west"],
            },
            LucideIconKind.SignpostBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "development", "gaming"],
                Tags = ["bidirectional", "left", "right", "east", "west"],
            },
            LucideIconKind.Siren => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["medical"],
                Tags = ["police", "ambulance", "emergency", "security", "alert", "alarm", "light"],
            },
            LucideIconKind.SkipBack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["multimedia", "arrows"],
                Tags = ["arrow", "previous", "music"],
            },
            LucideIconKind.SkipForward => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["multimedia", "arrows"],
                Tags = ["arrow", "skip", "next", "music"],
            },
            LucideIconKind.Skull => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["gaming"],
                Tags = ["death", "danger", "bone"],
            },
            LucideIconKind.Slack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ashygee", "wojtekmaj", "mittalyashu", "ericfennis"],
                Categories = ["account", "social", "brands", "development"],
                Tags = ["logo"],
            },
            LucideIconKind.Slash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "math"],
                Tags = ["divide", "division", "or", "/"],
            },
            LucideIconKind.Slice => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["design"],
                Tags = ["cutter", "scalpel", "knife"],
            },
            LucideIconKind.SlidersHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["account"],
                Tags = ["settings", "filters", "controls"],
            },
            LucideIconKind.SlidersVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["account"],
                Tags = ["settings", "controls"],
            },
            LucideIconKind.Smartphone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "mittalyashu", "ericfennis"],
                Categories = ["connectivity", "devices"],
                Tags = ["phone", "cellphone", "device", "screen"],
            },
            LucideIconKind.SmartphoneCharging => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["connectivity", "devices"],
                Tags = ["phone", "cellphone", "device", "power", "screen"],
            },
            LucideIconKind.SmartphoneNfc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["communication", "finance", "devices"],
                Tags = ["contactless", "payment", "near-field communication", "screen"],
            },
            LucideIconKind.Smile => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["emoji", "account"],
                Tags = ["emoji", "face", "happy", "good", "emotion"],
            },
            LucideIconKind.SmilePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["emoji", "social", "notifications", "communication"],
                Tags = ["emoji", "face", "happy", "good", "emotion", "react", "reaction", "add"],
            },
            LucideIconKind.Snail => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["animals", "food-beverage"],
                Tags = ["animal", "insect", "slow", "speed", "delicacy", "spiral"],
            },
            LucideIconKind.Snowflake => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "lscheibel", "ericfennis"],
                Categories = ["weather", "seasons"],
                Tags = ["cold", "weather", "freeze", "snow", "winter"],
            },
            LucideIconKind.SoapDispenserDroplet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "jguddas"],
                Categories = ["home", "travel"],
                Tags = ["wash", "bath", "water", "liquid", "fluid", "wet", "moisture", "damp", "bead", "globule"],
            },
            LucideIconKind.Sofa => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["home"],
                Tags = ["armchair", "furniture", "leisure", "lounge", "loveseat", "couch"],
            },
            LucideIconKind.Soup => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kemie"],
                Categories = ["food-beverage"],
                Tags = ["food", "dish", "restaurant", "course", "meal", "bowl", "starter"],
            },
            LucideIconKind.Space => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text"],
                Tags = ["text", "selection", "letters", "characters", "font", "typography"],
            },
            LucideIconKind.Spade => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jguddas"],
                Categories = ["shapes", "gaming"],
                Tags = ["shape", "suit", "playing", "cards"],
            },
            LucideIconKind.Sparkle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Shiva953", "karsa-mistmere"],
                Categories = ["shapes"],
                Tags = ["star", "effect", "filter", "night", "magic", "shiny", "glitter", "twinkle", "celebration"],
            },
            LucideIconKind.Sparkles => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["cursors", "multimedia", "gaming", "weather"],
                Tags = ["stars", "effect", "filter", "night", "magic"],
            },
            LucideIconKind.Speaker => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "danielbayley"],
                Categories = ["multimedia", "devices"],
                Tags = ["sound", "audio", "music", "tweeter", "subwoofer", "bass", "production", "producer", "dj"],
            },
            LucideIconKind.Speech => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["doerge", "airone01", "jguddas", "karsa-mistmere"],
                Categories = ["accessibility", "communication"],
                Tags = ["disability", "disabled", "dda", "human", "accessibility", "people", "sound"],
            },
            LucideIconKind.SpellCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "development"],
                Tags = ["spelling", "error", "mistake", "oversight", "typo", "correction", "code", "linter", "a"],
            },
            LucideIconKind.SpellCheck2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["text", "development"],
                Tags = ["spelling", "error", "mistake", "oversight", "typo", "correction", "code", "linter", "a"],
            },
            LucideIconKind.Spline => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas"],
                Categories = ["design"],
                Tags = ["path", "pen", "tool", "shape", "curve", "draw"],
            },
            LucideIconKind.SplinePointer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["kaleidosium", "mittalyashu", "ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["arrows", "cursors", "design", "tools"],
                Tags = ["path", "tool", "curve", "node", "click", "pointer", "target", "vector"],
            },
            LucideIconKind.Split => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["development", "arrows"],
                Tags = ["break", "disband", "divide", "separate", "branch", "disunite"],
            },
            LucideIconKind.Spool => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["communication", "tools", "social"],
                Tags = ["bobbin", "spindle", "yarn", "thread", "string", "sewing", "needlework"],
            },
            LucideIconKind.Spotlight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme", "jguddas", "karsa-mistmere", "ericfennis"],
                Categories = ["devices", "photography", "multimedia", "communication"],
                Tags = ["winner", "soapbox", "stage", "entertainment", "drama", "podium", "actor", "actress", "singer", "light", "beam", "play", "theatre", "show", "focus", "concert", "performance", "lens", "leaderboard", "followspot", "best", "highlight"],
            },
            LucideIconKind.SprayCan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["design", "tools"],
                Tags = ["paint", "color", "graffiti", "decoration", "aerosol", "deodorant", "shaving foam", "air freshener"],
            },
            LucideIconKind.Sprout => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu", "jamiemlaw", "karsa-mistmere", "jguddas"],
                Categories = ["nature", "gaming", "sustainability"],
                Tags = ["eco", "green", "growth", "leaf", "nature", "plant", "seed", "spring", "sustainability"],
            },
            LucideIconKind.Square => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["shapes", "multimedia"],
                Tags = ["stop", "playback", "music", "audio", "video", "rectangle", "aspect ratio", "1:1", "shape"],
            },
            LucideIconKind.SquareActivity => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["medical", "social", "science", "multimedia"],
                Tags = ["pulse", "action", "motion", "movement", "exercise", "fitness", "healthcare", "heart rate monitor", "vital signs", "vitals", "emergency room", "er", "intensive care", "hospital", "defibrillator", "earthquake", "siesmic", "magnitude", "richter scale", "aftershock", "tremor", "shockwave", "audio", "waveform", "synthesizer", "synthesiser", "music"],
            },
            LucideIconKind.SquareArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["backwards", "reverse", "direction", "south", "sign", "keyboard", "button"],
            },
            LucideIconKind.SquareArrowDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["direction", "south-west", "diagonal", "sign", "turn", "keyboard", "button"],
            },
            LucideIconKind.SquareArrowDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "gaming"],
                Tags = ["direction", "south-east", "diagonal", "sign", "turn", "keyboard", "button"],
            },
            LucideIconKind.SquareArrowLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["previous", "back", "direction", "west", "sign", "keyboard", "button", "<-"],
            },
            LucideIconKind.SquareArrowOutDownLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "south-west", "diagonal"],
            },
            LucideIconKind.SquareArrowOutDownRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "south-east", "diagonal"],
            },
            LucideIconKind.SquareArrowOutUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["outwards", "direction", "north-west", "diagonal"],
            },
            LucideIconKind.SquareArrowOutUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "social"],
                Tags = ["outwards", "direction", "north-east", "diagonal", "share", "open", "external", "link"],
            },
            LucideIconKind.SquareArrowRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["next", "forward", "direction", "west", "sign", "keyboard", "button", "->"],
            },
            LucideIconKind.SquareArrowUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["forward", "direction", "north", "sign", "keyboard", "button"],
            },
            LucideIconKind.SquareArrowUpLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation"],
                Tags = ["direction", "north-west", "diagonal", "sign", "keyboard", "button"],
            },
            LucideIconKind.SquareArrowUpRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "navigation", "social"],
                Tags = ["direction", "north-east", "diagonal", "sign", "keyboard", "button", "share"],
            },
            LucideIconKind.SquareAsterisk => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "security", "math", "development"],
                Tags = ["password", "secret", "access", "key", "multiply", "multiplication", "glob pattern", "wildcard", "*"],
            },
            LucideIconKind.SquareBottomDashedScissors => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "design", "tools", "files", "development"],
                Tags = ["cut", "snippet", "chop", "stationery", "crafts"],
            },
            LucideIconKind.SquareChartGantt => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["charts", "time", "development", "design"],
                Tags = ["projects", "manage", "overview", "roadmap", "plan", "intentions", "timeline", "deadline", "date", "event", "range", "period", "productivity", "work", "agile", "code", "coding", "toolbar", "button"],
            },
            LucideIconKind.SquareCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.SquareCheckBig => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jguddas"],
                Categories = ["notifications"],
                Tags = ["done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.SquareChevronDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "menu", "panel"],
            },
            LucideIconKind.SquareChevronLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation"],
                Tags = ["back", "previous", "less than", "fewer", "menu", "panel", "button", "keyboard", "<"],
            },
            LucideIconKind.SquareChevronRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "development"],
                Tags = ["forward", "next", "more than", "greater", "menu", "panel", "code", "coding", "command line", "terminal", "prompt", "shell", "console", ">"],
            },
            LucideIconKind.SquareChevronUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["arrows", "navigation", "math"],
                Tags = ["caret", "keyboard", "button", "mac", "control", "ctrl", "superscript", "exponential", "power", "ahead", "menu", "panel", "^"],
            },
            LucideIconKind.SquareCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere", "ericfennis"],
                Categories = ["text", "development"],
                Tags = ["gist", "source", "programming", "html", "xml", "coding"],
            },
            LucideIconKind.SquareDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["llaenowyd", "mishkaio", "ericfennis", "karsa-mistmere", "chessurisme"],
                Categories = ["text", "design"],
                Tags = ["selection", "square", "rectangular", "marquee", "tool", "dashed", "box"],
            },
            LucideIconKind.SquareDashedBottom => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "files"],
                Tags = ["rectangle", "aspect ratio", "1:1", "shape", "snippet", "code", "coding"],
            },
            LucideIconKind.SquareDashedBottomCode => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "files"],
                Tags = ["rectangle", "aspect ratio", "1:1", "shape", "snippet", "code", "coding"],
            },
            LucideIconKind.SquareDashedKanban => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["charts", "development", "design"],
                Tags = ["projects", "manage", "overview", "board", "tickets", "issues", "roadmap", "plan", "intentions", "productivity", "work", "agile", "draft", "template", "boilerplate", "code", "coding"],
            },
            LucideIconKind.SquareDashedMousePointer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "cursors", "development", "tools"],
                Tags = ["inspector", "element", "mouse", "click", "pointer", "box", "browser", "selector", "target", "dom", "node"],
            },
            LucideIconKind.SquareDashedTopSolid => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["llaenowyd", "mishkaio", "ericfennis", "karsa-mistmere", "chessurisme", "danielbayley", "colebemis", "juanpablofernandez"],
                Categories = ["design", "development", "layout"],
                Tags = ["square", "border", "width", "layout", "style", "design", "rectangular", "marquee", "dashed", "box", "rectangle", "aspect ratio", "1:1"],
            },
            LucideIconKind.SquareDivide => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["csandman", "ericfennis"],
                Categories = ["math"],
                Tags = ["calculate", "math", "÷", "/"],
            },
            LucideIconKind.SquareDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["development"],
                Tags = ["git", "diff", "modified", "."],
            },
            LucideIconKind.SquareEqual => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["math"],
                Tags = ["calculate", "="],
            },
            LucideIconKind.SquareFunction => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["development", "math"],
                Tags = ["programming", "code", "automation", "math"],
            },
            LucideIconKind.SquareKanban => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["charts", "development", "design"],
                Tags = ["projects", "manage", "overview", "board", "tickets", "issues", "roadmap", "plan", "intentions", "productivity", "work", "agile", "code", "coding", "toolbar", "button"],
            },
            LucideIconKind.SquareLibrary => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "photography", "multimedia", "navigation", "development"],
                Tags = ["books", "reading", "written", "authors", "stories", "fiction", "novels", "information", "knowledge", "education", "high school", "university", "college", "academy", "learning", "study", "research", "collection", "vinyl", "records", "albums", "music", "package"],
            },
            LucideIconKind.SquareM => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas", "karsa-mistmere"],
                Categories = ["transportation", "navigation"],
                Tags = ["metro", "subway", "underground", "track", "line"],
            },
            LucideIconKind.SquareMenu => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["layout"],
                Tags = ["bars", "navigation", "hamburger", "options", "menu bar", "panel"],
            },
            LucideIconKind.SquareMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "development", "text", "tools", "devices"],
                Tags = ["subtract", "remove", "decrease", "reduce", "calculator", "button", "keyboard", "line", "divider", "separator", "horizontal rule", "hr", "html", "markup", "markdown", "---", "toolbar", "operator", "code", "coding", "minimum", "downgrade"],
            },
            LucideIconKind.SquareMousePointer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["arrows", "cursors", "development", "tools"],
                Tags = ["inspector", "element", "mouse", "click", "pointer", "box", "browser", "selector", "target", "dom", "node"],
            },
            LucideIconKind.SquareParking => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["transportation", "navigation"],
                Tags = ["parking lot", "car park"],
            },
            LucideIconKind.SquareParkingOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["transportation", "navigation"],
                Tags = ["parking lot", "car park", "no parking"],
            },
            LucideIconKind.SquarePause => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["music", "audio", "stop"],
            },
            LucideIconKind.SquarePen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["text"],
                Tags = ["pencil", "edit", "change", "create", "draw", "sketch", "draft", "writer", "writing", "biro", "ink", "marker", "felt tip", "stationery", "artist"],
            },
            LucideIconKind.SquarePercent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["social", "finance", "shopping", "math"],
                Tags = ["verified", "unverified", "sale", "discount", "offer", "marketing", "sticker", "price tag"],
            },
            LucideIconKind.SquarePi => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["development", "math"],
                Tags = ["constant", "code", "coding", "programming", "symbol", "trigonometry", "geometry", "formula"],
            },
            LucideIconKind.SquarePilcrow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text"],
                Tags = ["paragraph", "mark", "paraph", "blind", "typography", "type", "text", "prose", "symbol"],
            },
            LucideIconKind.SquarePlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["arrows", "multimedia"],
                Tags = ["music", "audio", "video", "start", "run"],
            },
            LucideIconKind.SquarePlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "tools", "development", "text"],
                Tags = ["add", "new", "increase", "increment", "positive", "calculate", "calculator", "button", "keyboard", "toolbar", "maximum", "upgrade", "extra", "operator", "join", "concatenate", "code", "coding", "+"],
            },
            LucideIconKind.SquarePower => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["connectivity"],
                Tags = ["on", "off", "device", "switch", "toggle", "binary", "boolean", "reboot", "restart", "button", "keyboard", "troubleshoot"],
            },
            LucideIconKind.SquareRadical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["smnandre"],
                Categories = ["development", "math"],
                Tags = ["calculate", "formula", "math", "operator", "root", "square", "symbol"],
            },
            LucideIconKind.SquareRoundCorner => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["liamb13", "jguddas"],
                Categories = ["design", "development", "layout"],
                Tags = ["border", "radius", "style", "design", "corner", "layout", "round", "rounded"],
            },
            LucideIconKind.SquareScissors => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "design", "tools", "files", "development"],
                Tags = ["cut", "snippet", "chop", "stationery", "crafts", "toolbar", "button"],
            },
            LucideIconKind.SquareSigma => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "math"],
                Tags = ["sum", "calculate", "formula", "math", "enumeration", "enumerate"],
            },
            LucideIconKind.SquareSlash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "ericfennis"],
                Categories = ["development", "math"],
                Tags = ["git", "diff", "ignored", "divide", "division", "shortcut", "or", "/"],
            },
            LucideIconKind.SquareSplitHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Patchethium", "ericfennis"],
                Categories = ["layout"],
                Tags = ["split", "divide"],
            },
            LucideIconKind.SquareSplitVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Patchethium", "ericfennis"],
                Categories = ["layout"],
                Tags = ["split", "divide"],
            },
            LucideIconKind.SquareSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas"],
                Categories = ["layout"],
                Tags = ["float", "center", "rectangle"],
            },
            LucideIconKind.SquareStack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "files", "development"],
                Tags = ["versions", "clone", "copy", "duplicate", "multiple", "revisions", "version control", "backup", "history"],
            },
            LucideIconKind.SquareStar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["sports", "gaming"],
                Tags = ["badge", "medal", "honour", "decoration", "order", "pin", "laurel", "trophy", "medallion", "insignia", "bronze", "silver", "gold"],
            },
            LucideIconKind.SquareStop => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["multimedia"],
                Tags = ["media", "music"],
            },
            LucideIconKind.SquareTerminal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "command line", "prompt", "shell"],
            },
            LucideIconKind.SquareUser => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.SquareUserRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.SquareX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["math", "notifications"],
                Tags = ["cancel", "close", "delete", "remove", "times", "clear", "math", "multiply", "multiplication"],
            },
            LucideIconKind.SquaresExclude => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "jguddas", "jamiemlaw", "karsa-mistmere"],
                Categories = ["design"],
                Tags = ["square", "pathfinder", "path", "exclude", "invert", "xor", "shape", "vector"],
            },
            LucideIconKind.SquaresIntersect => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "jguddas", "karsa-mistmere"],
                Categories = ["design"],
                Tags = ["square", "pathfinder", "path", "intersect", "shape", "include", "vector"],
            },
            LucideIconKind.SquaresSubtract => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "jguddas", "karsa-mistmere"],
                Categories = ["design"],
                Tags = ["square", "pathfinder", "path", "minus", "subtract", "subtraction", "shape", "front", "vector"],
            },
            LucideIconKind.SquaresUnite => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "jguddas", "karsa-mistmere"],
                Categories = ["design"],
                Tags = ["square", "pathfinder", "path", "unite", "union", "shape", "merge", "vector"],
            },
            LucideIconKind.Squircle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas"],
                Categories = ["shapes"],
                Tags = ["shape"],
            },
            LucideIconKind.SquircleDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "aramsoneson"],
                Categories = ["development", "shapes", "design"],
                Tags = ["shape", "pending", "progress", "issue", "draft", "code", "coding", "version control"],
            },
            LucideIconKind.Squirrel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["animals"],
                Tags = ["animal", "rodent", "pet", "pest", "nuts", "retrieve", "updates", "storage", "stash"],
            },
            LucideIconKind.Stamp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["design", "cursors", "tools"],
                Tags = ["mark", "print", "clone", "loyalty", "library"],
            },
            LucideIconKind.Star => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "jguddas"],
                Categories = ["account", "social", "shapes", "multimedia", "weather", "emoji", "gaming"],
                Tags = ["bookmark", "favorite", "like", "review", "rating"],
            },
            LucideIconKind.StarHalf => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "jguddas"],
                Categories = ["social", "multimedia"],
                Tags = ["bookmark", "favorite", "like", "review", "rating"],
            },
            LucideIconKind.StarOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["multimedia", "social"],
                Tags = ["dislike", "unlike", "remove", "unrate"],
            },
            LucideIconKind.StepBack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "arrows"],
                Tags = ["arrow", "previous", "music", "left", "reverse"],
            },
            LucideIconKind.StepForward => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["multimedia", "arrows"],
                Tags = ["arrow", "next", "music", "right", "continue"],
            },
            LucideIconKind.Stethoscope => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["science", "medical"],
                Tags = ["phonendoscope", "medical", "heart", "lungs", "sound"],
            },
            LucideIconKind.Sticker => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["social"],
                Tags = ["reaction", "emotion", "smile", "happy", "feedback"],
            },
            LucideIconKind.StickyNote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "danielbayley"],
                Categories = ["text", "social"],
                Tags = ["post-it", "comment", "annotation", "reaction", "memo", "reminder", "todo", "task", "idea", "brainstorm", "document", "page", "paper", "sheet", "stationary", "office"],
            },
            LucideIconKind.Store => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "navigation", "shopping"],
                Tags = ["shop", "supermarket", "stand", "boutique", "building"],
            },
            LucideIconKind.StretchHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify", "distribute"],
            },
            LucideIconKind.StretchVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["layout"],
                Tags = ["items", "flex", "justify", "distribute"],
            },
            LucideIconKind.Strikethrough => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "johnletey", "csandman"],
                Categories = ["text"],
                Tags = ["cross out", "delete", "remove", "format"],
            },
            LucideIconKind.Subscript => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["nabanita-sarkar", "ericfennis", "mittalyashu"],
                Categories = ["text"],
                Tags = ["text"],
            },
            LucideIconKind.Sun => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["accessibility", "weather", "seasons", "sustainability"],
                Tags = ["brightness", "weather", "light", "summer"],
            },
            LucideIconKind.SunDim => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "bduffany", "karsa-mistmere"],
                Categories = ["accessibility", "weather"],
                Tags = ["brightness", "dim", "low", "brightness low"],
            },
            LucideIconKind.SunMedium => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "karsa-mistmere"],
                Categories = ["accessibility", "weather"],
                Tags = ["brightness", "medium"],
            },
            LucideIconKind.SunMoon => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zishankadri", "jamiemlaw", "jguddas"],
                Categories = ["accessibility"],
                Tags = ["dark", "light", "moon", "sun", "brightness", "theme", "auto theme", "system theme", "appearance"],
            },
            LucideIconKind.SunSnow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["weather", "air conditioning", "temperature", "hot", "cold", "seasons"],
            },
            LucideIconKind.Sunrise => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["arrows", "weather", "time"],
                Tags = ["weather", "time", "morning", "day"],
            },
            LucideIconKind.Sunset => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["arrows", "weather"],
                Tags = ["weather", "time", "evening", "night"],
            },
            LucideIconKind.Superscript => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["nabanita-sarkar", "ericfennis"],
                Categories = ["text"],
                Tags = ["text", "exponent"],
            },
            LucideIconKind.SwatchBook => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["design", "home", "photography"],
                Tags = ["colors", "colours", "swatches", "pantone", "shades", "tint", "hue", "saturation", "brightness", "theme", "scheme", "palette", "samples", "textile", "carpet"],
            },
            LucideIconKind.SwissFranc => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "mittalyashu"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.SwitchCamera => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "csandman", "ericfennis"],
                Categories = ["communication", "devices"],
                Tags = ["photo", "selfie", "front", "back"],
            },
            LucideIconKind.Sword => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["gaming", "tools"],
                Tags = ["battle", "challenge", "game", "war", "weapon"],
            },
            LucideIconKind.Swords => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["gaming", "tools"],
                Tags = ["battle", "challenge", "game", "war", "weapon"],
            },
            LucideIconKind.Syringe => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["science", "medical"],
                Tags = ["medicine", "medical", "needle", "pump", "plunger", "nozzle", "blood"],
            },
            LucideIconKind.Table => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "zenoamaro", "ericfennis", "csandman", "mittalyashu"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid"],
            },
            LucideIconKind.Table2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["abejenaru", "karsa-mistmere", "ericfennis"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid"],
            },
            LucideIconKind.TableCellsMerge => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid", "row"],
            },
            LucideIconKind.TableCellsSplit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid", "row"],
            },
            LucideIconKind.TableColumnsSplit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid", "cut", "break", "divide", "separate", "segment"],
            },
            LucideIconKind.TableOfContents => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["text"],
                Tags = ["toc", "outline", "navigation", "document structure", "index", "overview", "sections", "chapters", "content", "documentation", "manual", "knowledge base", "faq"],
            },
            LucideIconKind.TableProperties => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "development", "files"],
                Tags = ["property list", "plist", "spreadsheet", "grid", "dictionary", "object", "hash"],
            },
            LucideIconKind.TableRowsSplit => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme"],
                Categories = ["text", "files"],
                Tags = ["spreadsheet", "grid", "cut", "break", "divide", "separate", "segment"],
            },
            LucideIconKind.Tablet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["devices"],
                Tags = ["device"],
            },
            LucideIconKind.TabletSmartphone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "design", "development", "tools"],
                Tags = ["responsive", "screens", "browser", "testing", "mobile"],
            },
            LucideIconKind.Tablets => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not", "ericfennis"],
                Categories = ["medical"],
                Tags = ["medicine", "medication", "drug", "prescription", "pills", "pharmacy"],
            },
            LucideIconKind.Tag => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "aaofyi", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["label", "badge", "ticket", "mark"],
            },
            LucideIconKind.Tags => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["account"],
                Tags = ["labels", "badges", "tickets", "marks", "copy", "multiple"],
            },
            LucideIconKind.Tally1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math", "gaming"],
                Tags = ["count", "score", "enumerate", "days", "one", "1", "first", "bar", "prison", "cell", "sentence"],
            },
            LucideIconKind.Tally2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math", "gaming"],
                Tags = ["count", "score", "enumerate", "days", "two", "2", "second", "double", "bars", "prison", "cell", "sentence"],
            },
            LucideIconKind.Tally3 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math", "gaming"],
                Tags = ["count", "score", "enumerate", "days", "three", "3", "third", "triple", "bars", "prison", "cell", "sentence"],
            },
            LucideIconKind.Tally4 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math", "gaming"],
                Tags = ["count", "score", "enumerate", "days", "4", "fourth", "quadruple", "bars", "prison", "cell", "sentence"],
            },
            LucideIconKind.Tally5 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["math", "gaming"],
                Tags = ["count", "score", "enumerate", "days", "five", "5", "fifth", "bars", "prison", "cell", "sentence", "slash", "/"],
            },
            LucideIconKind.Tangent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["shapes", "math", "design", "tools"],
                Tags = ["tangential", "shape", "circle", "geometry", "trigonometry", "bezier curve"],
            },
            LucideIconKind.Target => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["brands", "gaming"],
                Tags = ["logo", "bullseye", "deadline", "projects", "overview", "work", "productivity"],
            },
            LucideIconKind.Telescope => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["science", "development", "tools"],
                Tags = ["astronomy", "space", "discovery", "exploration", "explore", "vision", "perspective", "focus", "stargazing", "observe", "view"],
            },
            LucideIconKind.Tent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["MoltenCoffee", "ericfennis", "danielbayley"],
                Categories = ["travel", "nature", "sustainability"],
                Tags = ["tipi", "teepee", "wigwam", "lodge", "camping", "campsite", "holiday", "retreat", "nomadic", "native american", "indian", "wilderness", "outdoors"],
            },
            LucideIconKind.TentTree => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["travel", "nature"],
                Tags = ["camping", "campsite", "holiday", "retreat", "nomadic", "wilderness", "outdoors"],
            },
            LucideIconKind.Terminal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["development"],
                Tags = ["code", "command line", "prompt", "shell"],
            },
            LucideIconKind.TestTube => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["science"],
                Tags = ["tube", "vial", "phial", "flask", "ampoule", "ampule", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.TestTubeDiagonal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["science"],
                Tags = ["tube", "vial", "phial", "flask", "ampoule", "ampule", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.TestTubes => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["science"],
                Tags = ["tubes", "vials", "phials", "flasks", "ampoules", "ampules", "lab", "chemistry", "experiment", "test"],
            },
            LucideIconKind.TextAlignCenter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "alignment", "center"],
            },
            LucideIconKind.TextAlignEnd => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "alignment", "right"],
            },
            LucideIconKind.TextAlignJustify => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "alignment", "justified", "menu", "list"],
            },
            LucideIconKind.TextAlignStart => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["text", "alignment", "left", "list"],
            },
            LucideIconKind.TextCursor => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["text", "cursors"],
                Tags = ["select"],
            },
            LucideIconKind.TextCursorInput => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere", "danielbayley", "jguddas"],
                Categories = ["text", "layout"],
                Tags = ["select"],
            },
            LucideIconKind.TextInitial => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "GRA0007", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["drop cap", "text", "format", "typography", "letter", "font size"],
            },
            LucideIconKind.TextQuote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["blockquote", "quotation", "indent", "reply", "response"],
            },
            LucideIconKind.TextSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["text"],
                Tags = ["find", "data", "copy", "txt", "pdf", "document", "scan", "magnifier", "magnifying glass", "lens"],
            },
            LucideIconKind.TextSelect => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "cursors"],
                Tags = ["find", "search", "selection", "dashed"],
            },
            LucideIconKind.TextWrap => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["bduffany", "ericfennis", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["words", "lines", "break", "paragraph"],
            },
            LucideIconKind.Theater => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["buildings", "social"],
                Tags = ["theater", "theatre", "entertainment", "podium", "stage", "musical"],
            },
            LucideIconKind.Thermometer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["temperature", "celsius", "fahrenheit", "weather"],
            },
            LucideIconKind.ThermometerSnowflake => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["weather"],
                Tags = ["temperature", "celsius", "fahrenheit", "weather", "cold", "freeze", "freezing"],
            },
            LucideIconKind.ThermometerSun => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["weather"],
                Tags = ["temperature", "celsius", "fahrenheit", "weather", "warm", "hot"],
            },
            LucideIconKind.ThumbsDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "social", "emoji"],
                Tags = ["dislike", "bad", "emotion"],
            },
            LucideIconKind.ThumbsUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "social", "emoji"],
                Tags = ["like", "good", "emotion"],
            },
            LucideIconKind.Ticket => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "perforated", "dashed"],
            },
            LucideIconKind.TicketCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "booked", "purchased", "receipt", "redeemed", "validated", "verified", "certified", "checked", "used"],
            },
            LucideIconKind.TicketMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "remove", "cancel", "unbook", "subtract", "decrease", "-"],
            },
            LucideIconKind.TicketPercent => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "shopping"],
                Tags = ["discount", "reduced", "offer", "voucher", "entry", "pass", "event", "concert", "show", "book", "purchase", "%"],
            },
            LucideIconKind.TicketPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "book", "purchase", "add", "+"],
            },
            LucideIconKind.TicketSlash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "redeemed", "used", "marked", "checked", "verified", "spoiled", "invalidated", "void", "denied", "refused", "banned", "barred", "forbidden", "prohibited", "cancelled", "cancellation", "refunded", "delete", "remove", "clear", "error"],
            },
            LucideIconKind.TicketX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["entry", "pass", "voucher", "event", "concert", "show", "cancelled", "cancellation", "refunded", "used", "void", "invalidated", "spoiled", "denied", "refused", "banned", "barred", "forbidden", "prohibited", "delete", "remove", "clear", "error", "x"],
            },
            LucideIconKind.Tickets => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas"],
                Categories = ["travel", "account", "transportation"],
                Tags = ["trip", "travel", "pass", "entry", "voucher", "event", "concert", "show", "perforated", "dashed"],
            },
            LucideIconKind.TicketsPlane => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas"],
                Categories = ["transportation", "travel"],
                Tags = ["plane", "trip", "airplane", "flight", "travel", "fly", "takeoff", "vacation", "passenger", "pass", "check-in", "airport"],
            },
            LucideIconKind.Timer => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "ericfennis"],
                Categories = ["time"],
                Tags = ["time", "timer", "stopwatch"],
            },
            LucideIconKind.TimerOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["time"],
                Tags = ["time", "timer", "stopwatch"],
            },
            LucideIconKind.TimerReset => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["time"],
                Tags = ["time", "timer", "stopwatch"],
            },
            LucideIconKind.ToggleLeft => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["layout", "account", "development"],
                Tags = ["on", "off", "switch", "boolean"],
            },
            LucideIconKind.ToggleRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jamiemlaw"],
                Categories = ["layout", "account", "development"],
                Tags = ["on", "off", "switch", "boolean"],
            },
            LucideIconKind.Toilet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["EthanHazel", "staffanmowitz", "karsa-mistmere", "jguddas"],
                Categories = ["devices", "home"],
                Tags = ["toilet", "potty", "bathroom", "washroom"],
            },
            LucideIconKind.ToolCase => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["AlexNaskida", "karsa-mistmere", "jguddas"],
                Categories = ["tools", "development", "home"],
                Tags = ["tools", "maintenance", "repair"],
            },
            LucideIconKind.Tornado => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["weather"],
                Tags = ["weather", "wind", "storm", "hurricane"],
            },
            LucideIconKind.Torus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["shapes", "design", "tools", "food-beverage"],
                Tags = ["donut", "doughnut", "ring", "hollow", "3d", "fast food", "junk food", "snack", "treat", "sweet", "sugar", "dessert"],
            },
            LucideIconKind.Touchpad => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["devices"],
                Tags = ["trackpad", "cursor"],
            },
            LucideIconKind.TouchpadOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["devices"],
                Tags = ["trackpad", "cursor"],
            },
            LucideIconKind.TowerControl => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "it-is-not"],
                Categories = ["travel", "transportation"],
                Tags = ["airport", "travel", "tower", "transportation", "lighthouse"],
            },
            LucideIconKind.ToyBrick => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "jguddas", "karsa-mistmere"],
                Categories = ["gaming", "development"],
                Tags = ["lego", "block", "addon", "plugin", "integration"],
            },
            LucideIconKind.Tractor => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["transportation", "sustainability", "food-beverage"],
                Tags = ["farming", "farmer", "ranch", "harvest", "equipment", "vehicle"],
            },
            LucideIconKind.TrafficCone => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere", "jamiemlaw"],
                Categories = ["transportation"],
                Tags = ["roadworks", "tarmac", "safety", "block"],
            },
            LucideIconKind.TrainFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation"],
                Tags = ["railway", "metro", "subway", "underground", "high-speed", "bullet", "fast", "track", "line"],
            },
            LucideIconKind.TrainFrontTunnel => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "navigation"],
                Tags = ["railway", "metro", "subway", "underground", "speed", "bullet", "fast", "track", "line"],
            },
            LucideIconKind.TrainTrack => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["transportation", "navigation"],
                Tags = ["railway", "line"],
            },
            LucideIconKind.TramFront => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "karsa-mistmere"],
                Categories = ["transportation"],
                Tags = ["railway", "metro", "subway", "underground", "track", "line", "tourism"],
            },
            LucideIconKind.Transgender => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["medical", "accessibility"],
                Tags = ["gender", "inclusive"],
            },
            LucideIconKind.Trash => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files", "mail"],
                Tags = ["empty", "deletion", "cleanup", "junk", "clear", "garbage", "delete", "remove", "bin", "waste", "recycle", "discard", "binoculars", "rubbish"],
            },
            LucideIconKind.Trash2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["files", "mail"],
                Tags = ["garbage", "delete", "remove", "bin"],
            },
            LucideIconKind.TreeDeciduous => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["nature", "sustainability"],
                Tags = ["tree", "forest", "park", "nature"],
            },
            LucideIconKind.TreePalm => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["nature", "sustainability"],
                Tags = ["vacation", "leisure", "island"],
            },
            LucideIconKind.TreePine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley"],
                Categories = ["nature", "sustainability"],
                Tags = ["tree", "pine", "forest", "park", "nature"],
            },
            LucideIconKind.Trees => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["nature", "sustainability"],
                Tags = ["tree", "forest", "park", "nature"],
            },
            LucideIconKind.Trello => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["bdbch", "csandman", "mittalyashu", "ericfennis"],
                Categories = ["account", "brands", "development"],
                Tags = ["logo", "brand"],
            },
            LucideIconKind.TrendingDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["charts", "arrows"],
                Tags = ["statistics"],
            },
            LucideIconKind.TrendingUp => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["charts", "arrows"],
                Tags = ["statistics"],
            },
            LucideIconKind.TrendingUpDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Alportan"],
                Categories = ["charts", "arrows"],
                Tags = ["arrows", "estimated", "indeterminate", "data fluctuation", "uncertain", "forecast", "variable", "prediction", "dynamic", "volatile"],
            },
            LucideIconKind.Triangle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["shapes"],
                Tags = ["equilateral", "delta", "shape", "pyramid", "hierarchy"],
            },
            LucideIconKind.TriangleAlert => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["notifications", "shapes", "development"],
                Tags = ["warning", "alert", "danger", "exclamation mark", "linter"],
            },
            LucideIconKind.TriangleDashed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "Yohh"],
                Categories = ["shapes"],
                Tags = ["equilateral", "delta", "shape", "pyramid", "hierarchy", "dashed"],
            },
            LucideIconKind.TriangleRight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "math"],
                Tags = ["volume", "controls", "controller", "tv remote", "geometry", "delta", "ramp", "slope", "incline", "increase"],
            },
            LucideIconKind.Trophy => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["sports", "gaming"],
                Tags = ["prize", "sports", "winner", "achievement", "award", "champion", "celebration", "victory"],
            },
            LucideIconKind.Truck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ahtohbi4", "ericfennis", "Andreto", "csandman", "karsa-mistmere", "danielbayley", "jordan808"],
                Categories = ["transportation"],
                Tags = ["delivery", "van", "shipping", "haulage", "lorry"],
            },
            LucideIconKind.TruckElectric => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ahtohbi4", "ericfennis", "Andreto", "csandman", "karsa-mistmere", "danielbayley", "jordan808", "LienMaas", "jguddas", "AnnaSasDev"],
                Categories = ["transportation"],
                Tags = ["delivery", "van", "shipping", "haulage", "lorry", "electric"],
            },
            LucideIconKind.TurkishLira => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["finance"],
                Tags = ["currency", "money", "payment"],
            },
            LucideIconKind.Turntable => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["multimedia", "home"],
                Tags = ["record player", "gramophone", "stereo", "phonograph", "vinyl", "lp", "disc", "platter", "cut", "music", "analog", "retro", "dj deck", "disc jockey", "scratch", "spinning"],
            },
            LucideIconKind.Turtle => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["animals"],
                Tags = ["animal", "pet", "tortoise", "slow", "speed"],
            },
            LucideIconKind.Tv => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["devices", "multimedia", "communication"],
                Tags = ["television", "stream", "display", "widescreen", "high-definition", "hd", "1080p", "4k", "8k", "smart", "digital", "video", "entertainment", "showtime", "channels", "terrestrial", "satellite", "cable", "broadcast", "live", "frequency", "tune", "scan", "aerial", "receiver", "transmission", "signal", "connection", "connectivity"],
            },
            LucideIconKind.TvMinimal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["devices", "multimedia"],
                Tags = ["flatscreen", "television", "stream", "display", "widescreen", "high-definition", "hd", "1080p", "4k", "8k", "smart", "digital", "video", "home cinema", "entertainment", "showtime", "channels", "catchup"],
            },
            LucideIconKind.TvMinimalPlay => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "ericfennis"],
                Categories = ["devices", "multimedia"],
                Tags = ["flatscreen", "television", "stream", "display", "widescreen", "high-definition", "hd", "1080p", "4k", "8k", "smart", "digital", "video", "movie", "live", "ott", "running", "start", "film", "home cinema", "entertainment", "showtime", "channels", "catchup"],
            },
            LucideIconKind.Twitch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ahtohbi4", "johnletey"],
                Categories = ["brands", "social", "account", "gaming"],
                Tags = ["logo", "social"],
            },
            LucideIconKind.Twitter => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["brands", "social", "account"],
                Tags = ["logo", "social"],
            },
            LucideIconKind.Type => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["text"],
                Tags = ["text", "font", "typography"],
            },
            LucideIconKind.TypeOutline => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "ericfennis"],
                Categories = ["text"],
                Tags = ["text", "font", "typography", "silhouette", "profile", "contour", "stroke", "line"],
            },
            LucideIconKind.Umbrella => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["weather"],
                Tags = ["rain", "weather"],
            },
            LucideIconKind.UmbrellaOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["weather"],
                Tags = ["rain", "weather", "uncovered", "uninsured", "antivirus", "unprotected", "risky"],
            },
            LucideIconKind.Underline => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "csandman", "johnletey"],
                Categories = ["text"],
                Tags = ["text", "format"],
            },
            LucideIconKind.Undo => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["aelfric", "ericfennis", "csandman"],
                Categories = ["text", "arrows"],
                Tags = ["redo", "rerun", "history"],
            },
            LucideIconKind.Undo2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "danielbayley", "karsa-mistmere"],
                Categories = ["text", "arrows"],
                Tags = ["redo", "rerun", "history", "back", "return", "reverse", "revert", "direction", "u-turn"],
            },
            LucideIconKind.UndoDot => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text", "arrows"],
                Tags = ["redo", "history", "step", "back"],
            },
            LucideIconKind.UnfoldHorizontal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "layout"],
                Tags = ["arrow", "collapse", "fold", "vertical", "dashed"],
            },
            LucideIconKind.UnfoldVertical => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["arrows", "layout"],
                Tags = ["arrow", "expand", "vertical", "dashed"],
            },
            LucideIconKind.Ungroup => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["shapes", "files"],
                Tags = ["cubes", "packages", "parts", "units", "collection", "cluster", "separate"],
            },
            LucideIconKind.University => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "navigation"],
                Tags = ["building", "education", "childhood", "school", "college", "academy", "institute"],
            },
            LucideIconKind.Unlink => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["text"],
                Tags = ["url", "unchain"],
            },
            LucideIconKind.Unlink2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis", "csandman"],
                Categories = ["text"],
                Tags = ["url", "unchain"],
            },
            LucideIconKind.Unplug => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["devices", "development"],
                Tags = ["electricity", "energy", "electronics", "socket", "outlet", "disconnect"],
            },
            LucideIconKind.Upload => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["arrows", "files"],
                Tags = ["file"],
            },
            LucideIconKind.Usb => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["devices", "multimedia", "home"],
                Tags = ["universal", "serial", "bus", "controller", "connector", "interface"],
            },
            LucideIconKind.User => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.UserCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["followed", "subscribed", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.UserCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "UsamaKhan"],
                Categories = ["account"],
                Tags = ["settings", "edit", "cog", "gear"],
            },
            LucideIconKind.UserLock => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["anthony-mariotti"],
                Categories = ["account", "security"],
                Tags = ["person", "lock", "locked", "account", "secure"],
            },
            LucideIconKind.UserMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["delete", "remove", "unfollow", "unsubscribe"],
            },
            LucideIconKind.UserPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["account"],
                Tags = ["person", "account", "contact", "profile", "edit", "change"],
            },
            LucideIconKind.UserPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["new", "add", "create", "follow", "subscribe"],
            },
            LucideIconKind.UserRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["person", "account", "contact"],
            },
            LucideIconKind.UserRoundCheck => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["followed", "subscribed", "done", "todo", "tick", "complete", "task"],
            },
            LucideIconKind.UserRoundCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "UsamaKhan"],
                Categories = ["account"],
                Tags = ["settings", "edit", "cog", "gear"],
            },
            LucideIconKind.UserRoundMinus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["delete", "remove", "unfollow", "unsubscribe"],
            },
            LucideIconKind.UserRoundPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "csandman", "ericfennis"],
                Categories = ["account"],
                Tags = ["person", "account", "contact", "profile", "edit", "change"],
            },
            LucideIconKind.UserRoundPlus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["new", "add", "create", "follow", "subscribe"],
            },
            LucideIconKind.UserRoundSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jmsv", "karsa-mistmere"],
                Categories = ["account", "social"],
                Tags = ["person", "account", "contact", "find", "scan", "magnifier", "magnifying glass", "lens"],
            },
            LucideIconKind.UserRoundX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["delete", "remove", "unfollow", "unsubscribe", "unavailable"],
            },
            LucideIconKind.UserSearch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jmsv", "jguddas", "colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account", "social"],
                Tags = ["person", "account", "contact", "find", "scan", "magnifier", "magnifying glass", "lens"],
            },
            LucideIconKind.UserStar => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas", "MArtytraM99"],
                Categories = ["account"],
                Tags = ["person", "account", "favorite", "contact", "like", "review", "rating", "admin"],
            },
            LucideIconKind.UserX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["account"],
                Tags = ["delete", "remove", "unfollow", "unsubscribe", "unavailable"],
            },
            LucideIconKind.Users => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["account"],
                Tags = ["group", "people"],
            },
            LucideIconKind.UsersRound => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["account"],
                Tags = ["group", "people"],
            },
            LucideIconKind.Utensils => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage", "travel", "navigation"],
                Tags = ["fork", "knife", "cutlery", "flatware", "tableware", "silverware", "food", "restaurant", "meal", "breakfast", "dinner", "supper"],
            },
            LucideIconKind.UtensilsCrossed => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage", "travel", "navigation"],
                Tags = ["fork", "knife", "cutlery", "flatware", "tableware", "silverware", "food", "restaurant", "meal", "breakfast", "dinner", "supper"],
            },
            LucideIconKind.UtilityPole => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "home", "sustainability"],
                Tags = ["electricity", "energy", "transmission line", "telegraph pole", "power lines", "phone"],
            },
            LucideIconKind.Variable => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development", "math"],
                Tags = ["code", "coding", "programming", "symbol", "calculate", "algebra", "x", "parentheses", "parenthesis", "brackets", "parameter", "(", ")"],
            },
            LucideIconKind.Vault => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["security", "travel", "home"],
                Tags = ["safe", "lockbox", "deposit", "locker", "coffer", "strongbox", "safety", "secure", "storage", "valuables", "bank"],
            },
            LucideIconKind.VectorSquare => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["chessurisme", "jguddas"],
                Categories = ["shapes", "math", "design", "tools"],
                Tags = ["shape", "geometry", "art", "width", "height", "size", "calculate", "measure", "select", "graphics", "box"],
            },
            LucideIconKind.Vegan => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["food-beverage", "sustainability"],
                Tags = ["vegetarian", "fruitarian", "herbivorous", "animal rights", "diet"],
            },
            LucideIconKind.VenetianMask => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["account", "gaming"],
                Tags = ["mask", "masquerade", "impersonate", "secret", "incognito"],
            },
            LucideIconKind.Venus => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jguddas", "jamiemlaw"],
                Categories = ["medical"],
                Tags = ["gender", "sex", "female", "feminine", "woman", "girl"],
            },
            LucideIconKind.VenusAndMars => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["jamiemlaw"],
                Categories = ["medical"],
                Tags = ["gender", "sex", "intersex", "androgynous", "hermaphrodite"],
            },
            LucideIconKind.Vibrate => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ericfennis"],
                Categories = ["devices", "connectivity", "account", "notifications"],
                Tags = ["smartphone", "notification", "rumble", "haptic feedback", "screen"],
            },
            LucideIconKind.VibrateOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["lscheibel", "ericfennis"],
                Categories = ["devices", "connectivity", "account"],
                Tags = ["smartphone", "notification", "rumble", "haptic feedback", "notifications", "screen"],
            },
            LucideIconKind.Video => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["devices", "communication", "connectivity", "photography"],
                Tags = ["camera", "movie", "film", "recording", "motion picture", "camcorder", "reel"],
            },
            LucideIconKind.VideoOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["devices", "communication", "connectivity", "photography"],
                Tags = ["camera", "movie", "film"],
            },
            LucideIconKind.Videotape => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["devices", "communication", "connectivity", "photography", "files"],
                Tags = ["vhs", "movie", "film", "recording", "motion picture", "showreel", "cassette"],
            },
            LucideIconKind.View => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["zenoamaro", "ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["design", "photography"],
                Tags = ["eye", "look"],
            },
            LucideIconKind.Voicemail => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["connectivity", "devices", "social"],
                Tags = ["phone", "cassette", "tape", "reel", "recording", "audio"],
            },
            LucideIconKind.Volleyball => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["sports", "gaming", "travel"],
                Tags = ["beach", "sand", "net", "holiday", "vacation", "summer", "soccer", "football", "futbol", "kick", "pitch", "goal", "score", "bounce", "leather", "wool", "yarn", "knitting", "sewing", "thread", "embroidery", "textile"],
            },
            LucideIconKind.Volume => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis"],
                Categories = ["connectivity", "communication", "multimedia"],
                Tags = ["music", "sound", "mute", "speaker"],
            },
            LucideIconKind.Volume1 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["connectivity", "communication", "multimedia"],
                Tags = ["music", "sound", "speaker"],
            },
            LucideIconKind.Volume2 => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere"],
                Categories = ["connectivity", "communication", "multimedia"],
                Tags = ["music", "sound", "speaker"],
            },
            LucideIconKind.VolumeOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "colebemis", "ericfennis"],
                Categories = ["connectivity", "communication", "multimedia"],
                Tags = ["music", "sound", "mute", "speaker"],
            },
            LucideIconKind.VolumeX => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["connectivity", "communication", "multimedia"],
                Tags = ["music", "sound", "mute", "speaker"],
            },
            LucideIconKind.Vote => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["ptrgast", "karsa-mistmere"],
                Categories = ["social"],
                Tags = ["vote", "poll", "ballot", "political", "social", "check", "tick"],
            },
            LucideIconKind.Wallet => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ahtohbi4", "ericfennis"],
                Categories = ["account", "finance"],
                Tags = ["money", "finance", "pocket"],
            },
            LucideIconKind.WalletCards => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account", "finance"],
                Tags = ["money", "finance", "pocket", "credit", "purchase", "payment", "shopping", "retail", "consumer", "cc"],
            },
            LucideIconKind.WalletMinimal => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["account", "finance"],
                Tags = ["finance", "pocket"],
            },
            LucideIconKind.Wallpaper => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis", "jguddas"],
                Categories = ["account", "devices"],
                Tags = ["background", "texture", "image", "art", "design", "visual", "decor", "pattern", "screen", "cover", "lock screen"],
            },
            LucideIconKind.Wand => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis"],
                Categories = ["design", "gaming", "cursors", "photography"],
                Tags = ["magic", "selection"],
            },
            LucideIconKind.WandSparkles => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["design", "gaming", "cursors", "photography"],
                Tags = ["magic", "wizard", "magician"],
            },
            LucideIconKind.Warehouse => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["buildings", "navigation"],
                Tags = ["storage", "storehouse", "depot", "depository", "repository", "stockroom", "logistics", "building"],
            },
            LucideIconKind.WashingMachine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["home", "devices", "travel"],
                Tags = ["tumble dryer", "amenities", "electronics", "cycle", "clothes", "rinse", "spin", "drum"],
            },
            LucideIconKind.Watch => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jamiemlaw"],
                Categories = ["time"],
                Tags = ["clock", "time"],
            },
            LucideIconKind.Waves => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["weather", "navigation", "multimedia", "sustainability"],
                Tags = ["water", "sea", "sound", "hertz", "wavelength", "vibrate"],
            },
            LucideIconKind.WavesLadder => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["sports", "home"],
                Tags = ["swimming", "water", "pool", "lifeguard", "ocean", "🌊", "🏊‍♂️", "🏊‍♀️", "🏊", "🥽"],
            },
            LucideIconKind.Waypoints => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["security", "account", "navigation", "development", "social"],
                Tags = ["indirection", "vpn", "virtual private network", "proxy", "connections", "bounce", "reroute", "path", "journey", "planner", "stops", "stations", "shared", "spread", "viral"],
            },
            LucideIconKind.Webcam => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["mittalyashu", "ericfennis", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "communication"],
                Tags = ["camera", "security"],
            },
            LucideIconKind.Webhook => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["development", "social", "account"],
                Tags = ["push api", "interface", "callback"],
            },
            LucideIconKind.WebhookOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas"],
                Categories = ["development", "social", "account"],
                Tags = ["push api", "interface", "callback"],
            },
            LucideIconKind.Weight => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "karsa-mistmere"],
                Categories = ["math"],
                Tags = ["mass", "heavy", "lead", "metal", "measure", "geometry", "scales", "balance"],
            },
            LucideIconKind.Wheat => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["food-beverage"],
                Tags = ["corn", "cereal", "grain", "gluten"],
            },
            LucideIconKind.WheatOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["corn", "cereal", "grain", "gluten free", "allergy", "intolerance", "diet"],
            },
            LucideIconKind.WholeWord => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley"],
                Categories = ["text"],
                Tags = ["text", "selection", "letters", "characters", "font", "typography"],
            },
            LucideIconKind.Wifi => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas"],
                Categories = ["connectivity", "devices"],
                Tags = ["connection", "signal", "wireless"],
            },
            LucideIconKind.WifiCog => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "karsa-mistmere", "luisdlopera"],
                Categories = ["connectivity", "devices", "files"],
                Tags = ["connection", "signal", "wireless", "directory", "settings", "control", "preferences", "cog", "edit", "gear"],
            },
            LucideIconKind.WifiHigh => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "VirtCode"],
                Categories = ["connectivity", "devices"],
                Tags = ["connection", "signal", "wireless"],
            },
            LucideIconKind.WifiLow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "VirtCode"],
                Categories = ["connectivity", "devices"],
                Tags = ["connection", "signal", "wireless"],
            },
            LucideIconKind.WifiOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["connectivity", "devices"],
                Tags = ["disabled"],
            },
            LucideIconKind.WifiPen => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "jguddas", "danielbayley", "luisdlopera"],
                Categories = ["connectivity", "devices"],
                Tags = ["edit", "wifi", "pen", "change", "network"],
            },
            LucideIconKind.WifiSync => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "danielbayley", "luisdlopera"],
                Categories = ["connectivity", "devices"],
                Tags = ["connection", "signal", "wireless", "synchronize", "reconnect", "reset", "restart"],
            },
            LucideIconKind.WifiZero => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis", "jguddas", "VirtCode"],
                Categories = ["connectivity", "devices"],
                Tags = ["connection", "signal", "wireless"],
            },
            LucideIconKind.Wind => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis"],
                Categories = ["weather", "sustainability"],
                Tags = ["weather", "air", "blow"],
            },
            LucideIconKind.WindArrowDown => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "jamiemlaw"],
                Categories = ["weather", "sustainability"],
                Tags = ["weather", "air", "pressure", "blow"],
            },
            LucideIconKind.Wine => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["alcohol", "beverage", "bar", "drink", "glass", "sommelier", "vineyard", "winery"],
            },
            LucideIconKind.WineOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere", "ericfennis"],
                Categories = ["food-beverage"],
                Tags = ["alcohol", "beverage", "drink", "glass", "alcohol free", "abstinence", "abstaining", "teetotalism", "allergy", "intolerance"],
            },
            LucideIconKind.Workflow => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["danielbayley", "jguddas"],
                Categories = ["development"],
                Tags = ["action", "continuous integration", "ci", "automation", "devops", "network", "node", "connection"],
            },
            LucideIconKind.Worm => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["karsa-mistmere"],
                Categories = ["animals", "security"],
                Tags = ["invertebrate", "grub", "larva", "snake", "crawl", "wiggle", "slither", "pest control", "computer virus", "malware"],
            },
            LucideIconKind.Wrench => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["Andreto", "ericfennis", "csandman", "karsa-mistmere"],
                Categories = ["account", "development", "tools"],
                Tags = ["account", "settings", "spanner", "diy", "toolbox", "build", "construction"],
            },
            LucideIconKind.X => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["notifications", "math"],
                Tags = ["cancel", "close", "cross", "delete", "ex", "remove", "times", "clear", "math", "multiply", "multiplication"],
            },
            LucideIconKind.Youtube => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "csandman", "ericfennis", "karsa-mistmere", "jguddas"],
                Categories = ["multimedia", "social", "brands"],
                Tags = ["logo", "social", "video", "play"],
            },
            LucideIconKind.Zap => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere"],
                Categories = ["connectivity", "devices", "photography", "weather"],
                Tags = ["flash", "camera", "lightning", "electricity", "energy"],
            },
            LucideIconKind.ZapOff => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "karsa-mistmere", "ericfennis"],
                Categories = ["connectivity", "devices", "photography", "weather"],
                Tags = ["flash", "camera", "lightning", "electricity", "energy"],
            },
            LucideIconKind.ZoomIn => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["accessibility", "layout", "design", "text", "photography"],
                Tags = ["magnifying glass", "plus"],
            },
            LucideIconKind.ZoomOut => new LucideIconInfo
            {
                Kind = kind,
                Contributors = ["colebemis", "ericfennis"],
                Categories = ["accessibility", "layout", "design", "text", "photography"],
                Tags = ["magnifying glass", "plus"],
            },
            _ => throw new InvalidOperationException(),
        };
    }
}
