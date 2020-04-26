#! /bin/sh

BASE_URL=https://download.unity3d.com/download_unity
HASH=ceef2d848e70
VERSION=2019.3.11f1

download() {
  file=$1
  url="$BASE_URL/$HASH/$package"

  echo "Downloading from $url: "
  curl -o `basename "$package"` "$url"
}

install() {
  package=$1
  download "$package"

  echo "Installing "`basename "$package"`
  sudo installer -dumplog -package `basename "$package"` -target /
}

# See $BASE_URL/$HASH/unity-$VERSION-$PLATFORM.ini for complete list
# of available packages, where PLATFORM is `osx` or `win`

install "MacEditorInstaller/Unity-$VERSION.pkg"
install "MacEditorTargetInstaller/UnitySetup-Windows-Mono-Support-for-Editor-$VERSION.pkg"
install "MacEditorTargetInstaller/Unity.pkg"
install "MacEditorTargetInstaller/UnitySetup-Linux-Mono-Support-for-Editor-$VERSION.pkg"

# https://download.unity3d.com/download_unity/27ab2135bccf/MacEditorTargetInstaller/Unity.pkg
# https://download.unity3d.com/download_unity/27ab2135bccf/MacEditorTargetInstaller/UnitySetup-Linux-Mono-Support-for-Editor-2019.3.0f6.pkg
# https://download.unity3d.com/download_unity/27ab2135bccf/MacEditorTargetInstaller/UnitySetup-Windows-Mono-Support-for-Editor-2019.3.0f6.pkg