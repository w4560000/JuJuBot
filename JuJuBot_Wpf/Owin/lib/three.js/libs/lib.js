debugger
import * as THREE from 'three'

import { GLTFLoader } from 'three/examples/jsm/loaders/GLTFLoader.js';

import { FBXLoader } from 'three/examples/jsm/loaders/FBXLoader.js';

import { RGBELoader } from 'three/examples/jsm/loaders/RGBELoader';

// import { DRACOLoader } from 'three/examples/jsm/loaders/DRACOLoader'

import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls';

import  Dat  from 'three/examples/jsm/libs/dat.gui.module.js';

import  Stats  from 'three/examples/jsm/libs/stats.module.js';


// 模型 Loader
THREE.GLTFLoader = GLTFLoader;

THREE.FBXLoader = FBXLoader;

// THREE.DRACOLoader = DRACOLoader

// HDR Loader
THREE.RGBELoader = RGBELoader;

// 控制器
THREE.OrbitControls = OrbitControls;

// 狀態面板
THREE.Dat = Dat;
THREE.Stats = Stats;

// 讓模型自動區中
THREE.ModelAutoCenter =function(group){
		/**
		 * 包圍盒全自動計算：模型整體區中
		 */
		var box3 = new THREE.Box3()
		// 計算層級模型group的包圍盒
		// 模型group是加載一個三維模型返回的對象，包含多個網格模型
		box3.expandByObject(group)
		// 計算一個層級模型對應包圍盒的幾何體中心在世界座標中的位置
		var center = new THREE.Vector3()
		box3.getCenter(center)
		// console.log('查看幾何體中心座標', center);

		// 重新設置模型的位置，使之居中。
		group.position.x = group.position.x - center.x
		group.position.y = group.position.y - center.y
		group.position.z = group.position.z - center.z
}

export default THREE;