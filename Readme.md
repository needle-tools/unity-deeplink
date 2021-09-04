# Deeplink – Set up deep links into the Unity editor

![Unity Version Compatibility](https://img.shields.io/badge/Unity-2019.4%20%E2%80%94%202021.2-brightgreen) 

## What's this?

Unity uses deeplinks for a number of AssetStore-related tasks, e.g. "Open in Unity" on the Asset Store website. This is cool but there's no official callback to tap into this mechanism for custom behaviours.  
This package adds a `[Deeplink]` attribute that can be set on a static method to have it called for specific deeplink requests.  
By default you can also install Unity packages (from registries you already have in your project).  

If this package is not in your project, custom deeplinks won't break anything - they'll just open a Package Manager window that doesn't do anything.

## Quick Start

Add this package to Unity:  

- Open Package Manager
- Click <kbd>+</kbd>
- Click <kbd>Add Package from git URL / name</kbd>
- Paste `https://github.com/needle-tools/unity-deeplink.git?path=/package`
- Click Enter.

Check out the sample as basis for custom stuff:  

- In Package Manager, select the new Deeplink package
- Import the Samples
- Double-click the `DeeplinkSample-Website` file to open in a browser
- Click the various links to interact with Unity.

## Test Links

These links will only work when this package is in your project.  
_Note: GitHub/OpenUPM doesn't seem to show these links properly. They work fine from a regular website._

- [Install MemoryProfiler Package](com.unity3d.kharma:install-package/com.unity.memoryprofiler) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:install-package/com.unity.memoryprofiler)  

These will only work when this package is in your project and you've imported the Sample.

- [Open Sample Scene](com.unity3d.kharma:open-scene/DeepLinkSample) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:open-scene/DeepLinkSample) 
- [Ping Receiver1](com.unity3d.kharma:selected-sample/Receiver1) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:selected-sample/Receiver1)
- [Ping Receiver2](com.unity3d.kharma:selected-sample/Receiver1) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:selected-sample/Receiver1) 

For reference, these are regular Unity deeplinks that work without this package:  

- [Install Unity 2021.1.19f1](unityhub://2021.1.19f1/5f5eb8bbdc25) [↗](https://fwd.needle.tools/deeplink?unityhub://2021.1.19f1/5f5eb8bbdc25)
- [Open Bolt in "My Assets"](com.unity3d.kharma:content/163802) [↗](https://fwd.needle.tools/deeplink?com.unity3d.kharma:content/163802)

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
