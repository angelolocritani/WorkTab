﻿// Karel Kroeze
// Resources.cs
// 2017-05-28

using UnityEngine;
using Verse;

namespace WorkTab
{
    [StaticConstructorOnStartup]
    public static class Resources
    {
        public static readonly Texture2D SortingIcon,
                                         SortingDescendingIcon,
                                         MoodHappy,
                                         MoodContent,
                                         MoodDiscontent,
                                         MoodUnhappy,
                                         MoodBroken,
                                         PrioritiesDetailed,
                                         PrioritiesSimple,
                                         PrioritiesTimed,
                                         PrioritiesWholeDay,
                                         PinEye,
                                         PinClock;

        static Resources()
        {
            SortingIcon = ContentFinder<Texture2D>.Get("UI/Icons/Sorting");
            SortingDescendingIcon = ContentFinder<Texture2D>.Get("UI/Icons/SortingDescending");
            MoodHappy = ContentFinder<Texture2D>.Get( "UI/Icons/Mood/happy" );
            MoodContent = ContentFinder<Texture2D>.Get( "UI/Icons/Mood/content" );
            MoodDiscontent = ContentFinder<Texture2D>.Get( "UI/Icons/Mood/discontent" );
            MoodUnhappy = ContentFinder<Texture2D>.Get( "UI/Icons/Mood/unhappy" );
            MoodBroken = ContentFinder<Texture2D>.Get( "UI/Icons/Mood/broken" );
            PrioritiesDetailed = ContentFinder<Texture2D>.Get( "UI/Icons/numbers" );
            PrioritiesSimple = ContentFinder<Texture2D>.Get( "UI/Icons/checks" );
            PrioritiesTimed = ContentFinder<Texture2D>.Get( "UI/Icons/clock-scheduler" );
            PrioritiesWholeDay = ContentFinder<Texture2D>.Get( "UI/Icons/clock-24hours" );
            PinEye = ContentFinder<Texture2D>.Get( "UI/Icons/pin-eye" );
            PinClock = ContentFinder<Texture2D>.Get( "UI/Icons/pin-clock" );
        }
    }
}