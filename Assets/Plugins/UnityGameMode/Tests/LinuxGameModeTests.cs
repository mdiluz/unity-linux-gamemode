using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
namespace Tests
{
    public class LinuxGameModeTests
    {
        [Test]
        public void GameModeRequestStartWorks()
        {
            var ret = LinuxGameMode.GameModeRequestStart();
            Assert.IsTrue( ret == 0 );
        }
        
        [Test]
        public void GameModeRequestEndWorks()
        {
            var ret = LinuxGameMode.GameModeRequestStart();
            Assert.IsTrue( ret == 0 );
            ret = LinuxGameMode.GameModeRequestEnd();
            Assert.IsTrue( ret == 0 );
        }
        
        [Test]
        public void GameModeGameModeQueryStatusWorks()
        {
            var ret = LinuxGameMode.GameModeRequestStart();
            Assert.IsTrue( ret == 0 );

            ret = LinuxGameMode.GameModeQueryStatus();
            Assert.IsTrue( ret == 2 );
            
            ret = LinuxGameMode.GameModeRequestEnd();
            Assert.IsTrue( ret == 0 );
        }
    }
}
#endif
