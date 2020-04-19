<template>
  <div id="app">
    <personinfo></personinfo>
  </div>
</template>
<script>
import personinfo from './views/personinfo'
export default {
  name: "app",
  components: {
    personinfo
  }
}
</script>
<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
}
body{
  margin: 0px;
}
</style>
