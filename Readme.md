# Deeplink – Set up deep links into the Unity editor

![Unity Version Compatibility](https://img.shields.io/badge/Unity-2019.4%20%E2%80%94%202021.2-brightgreen) 

## What's this?

Unity uses deeplinks for a number of AssetStore-related tasks, e.g. "Open in Unity" on the Asset Store website. This is cool but there's no official callback to tap into this mechanism for custom behaviours.  

This package adds a `[Deeplink]` attribute that can be set on a static method to have it called for specific deeplink requests.  

It also adds support to 2019 & 2020 for the upmpackage installation deeplink that's available from 2021.2+:  
[com.unity3d.kharma:upmpackage/com.unity.memoryprofiler](com.unity3d.kharma:upmpackage/com.unity.memoryprofiler) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:upmpackage/com.unity.memoryprofiler)
which means you can start using that in projects today.

The built-in upmpackage/ format just calls PackMan to add that package – so if it's from a scoped registry and you have that registry properly set up, it will just work.  

## Quick Start

This package is also available on [OpenUPM](https://openupm.com/packages/com.needle.deeplink/).  
Add this package to Unity:  

- Open Package Manager
- Click <kbd>+</kbd>
- Click <kbd>Add Package from git URL / name</kbd>
- Paste `https://github.com/needle-tools/unity-deeplink.git?path=/package`
- Press Enter.

Check out the sample as basis for custom stuff:  

- In Package Manager, select the new Deeplink package
- Import the Samples
- Double-click the `DeeplinkSample-Website` file to open in a browser
- Click the various links to interact with Unity.

## Test Links

_Note: GitHub messes up some of these links. They work fine from a regular website. Use the ↗ links from there._

UPM package installation links will work when this package is in your project, or without the package when you're on 2021.2+.  

- [Install MemoryProfiler Package](com.unity3d.kharma:install-package/com.unity.memoryprofiler) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:upmpackage/com.unity.memoryprofiler)  

These will only work when this package is in your project and you've imported the Sample.

- [Open Sample Scene](com.unity3d.kharma:open-scene/DeepLinkSample) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:open-scene/DeepLinkSample) 
- [Ping Receiver1](com.unity3d.kharma:selected-sample/Receiver1) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:selected-sample/Receiver1)
- [Ping Receiver2](com.unity3d.kharma:selected-sample/Receiver1) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:selected-sample/Receiver1) 

For reference, these are regular Unity deeplinks:  

- [Install Unity 2021.1.19f1](unityhub://2021.1.19f1/5f5eb8bbdc25) [↗](https://fwd.needle.tools/deeplink?unityhub://2021.1.19f1/5f5eb8bbdc25)
- [Open Bolt in "My Assets"](com.unity3d.kharma:content/163802) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:content/163802)
- [Install MemoryProfiler](com.unity3d.kharma:upmpackage/com.unity.memoryprofiler) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:upmpackage/com.unity.memoryprofiler)

## Deeplinks from GitHub markdown / Slack / Discord / etc

Many non-browsers (messaging tools, markdown viewers, ...) don't support deeplinks directly.  
You can use our deeplink forwarder for these cases: 

- [Install MemoryProfiler Package (Slack-compatible link)](https://fwd.needle.tools/deeplink?com.unity3d.kharma:install-package/com.unity.memoryprofiler)  

The forwarder is located at `https://fwd.needle.tools/deeplink?` and supports links starting with `com.unity3d.kharma:` or `unityhub://`.

## Related Issues
- GitHub Markdown strips custom protocol links: https://github.community/t/deeplink-urls-are-stripped-from-github-markdown/199464
- OpenUPM changes links to be relative when they use custom protocols: https://github.com/openupm/openupm/issues/2393

## Contact
<b>[needle — tools for unity](https://needle.tools)</b> • 
[Discord Community](https://discord.gg/UHwvwjs9Vp) • 
[@NeedleTools](https://twitter.com/NeedleTools) • 
[@marcel_wiessler](https://twitter.com/marcel_wiessler) • 
[@hybridherbst](https://twitter.com/hybridherbst)
