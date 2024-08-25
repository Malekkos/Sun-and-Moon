<template>
  <div class="homeLayoutWrapper">
    <div class="navTop">
      <img id="iconSun" src="../public/SUN.png" />
      <img id="iconAnd" src="../public/&.png" />
      <div id="layerForSwitcher"></div>
      <button @click="onClick" id="sunAndMoonSwitcher"><img src="../public/sunPicture.png" /></button>
      <img id="iconMoon" src="../public/MOON.png" />
    </div>
    <slot>
    </slot>
    <div class="navBottom">
      home layout ~ Home page bottom
    </div>
  </div>
</template>

<script lang="ts" setup>

  const onClick = () => {
    console.log("clicked the button")
  }



</script>

<style lang="postcss" scoped>
.navTop,
.navBottom {
  @apply flex justify-center w-full h-20 items-center;
}

.homeLayoutWrapper {
  @apply w-full bg-[#FFE7B8];
}

#iconAnd,
#iconSun,
#iconMoon {
  @apply relative;
}

#iconAnd {
  @apply left-[3.2rem] top-[4rem] z-20;
}

#iconSun {
  @apply left-[4.2rem] top-[6.4rem];
}

#iconMoon {
  @apply top-[5.2rem] right-[6.1rem];
}

#layerForSwitcher {
  @apply relative right-[4.4rem] w-[3.9rem] top-[6.4rem] bg-[gray] h-[4rem] z-10
}

#sunAndMoonSwitcher {
  @apply relative right-[7.9rem] top-[6.4rem] w-[3.7rem] h-[4rem] z-30;
}
</style>