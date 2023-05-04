# StableDiffusionWebUI-Unity-Integration v1.0
Unity integration for Stable Diffusion WebUI by AUTOMATIC1111: https://github.com/AUTOMATIC1111/stable-diffusion-webui
utilizing Naughty Attributes by Denis Rizov: https://github.com/dbrizov/NaughtyAttributes

Work in Progress

Developed with WebUI running on an external server running on http. (Does not support https currently)
Configure login data to the external server in "SD Config"

Features:
Text to Image (supports single and multiple images in one request)
Background Removal (using the extension: https://github.com/AUTOMATIC1111/stable-diffusion-webui-rembg (Current implementation is utilizing a bug in the extension, will need proper implementation soon.)

Planned Features:
Image to Image
Save generated images to file (they are currently generated and stored only during runtime)
